using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CompraInsumos : Form
    {
        BLL.CompraInsumo bllCompraInsumo = new BLL.CompraInsumo(); 
        BLL.Proveedor bllProveedor = new BLL.Proveedor();
        public CompraInsumos()
        {
            InitializeComponent();
        }

        private void ConfigurarGrilla()
        {
            datagridCompraInsumos.Columns.Clear();

            // ID oculto
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "idInsumo";
            colId.Visible = false;
            datagridCompraInsumos.Columns.Add(colId);

            // Combo Insumo
            DataGridViewTextBoxColumn colInsumo = new DataGridViewTextBoxColumn();
            colInsumo.Name = "Insumo";
            datagridCompraInsumos.Columns.Add(colInsumo);

            // Cantidad
            DataGridViewTextBoxColumn cantidad = new DataGridViewTextBoxColumn();
            cantidad.Name = "Cantidad";
            datagridCompraInsumos.Columns.Add(cantidad);

            // Precio
            DataGridViewTextBoxColumn precio = new DataGridViewTextBoxColumn();
            precio.Name = "Precio Unitario";
            datagridCompraInsumos.Columns.Add(precio);

            // Subtotal
            datagridCompraInsumos.Columns.Add("Subtotal", "Subtotal");
            datagridCompraInsumos.Columns["Subtotal"].ReadOnly = true;


        }

        private void btnAgregarProdInsumos_Click(object sender, EventArgs e)
        {
            datagridCompraInsumos.Rows.Add();
        }

        private void btnEliminarProdInsumos_Click(object sender, EventArgs e)
        {
            if (datagridCompraInsumos.CurrentRow != null)
            {
                datagridCompraInsumos.Rows.Remove(datagridCompraInsumos.CurrentRow);
                CalcularTotal();
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in datagridCompraInsumos.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }

            lblTotalCompra.Text = total.ToString("0.00");
        }

        private void datagridCompraInsumos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = datagridCompraInsumos.Rows[e.RowIndex];

            if (row.Cells["Cantidad"].Value != null &&
                row.Cells["Precio Unitario"].Value != null)
            {
                decimal cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                decimal precio = Convert.ToDecimal(row.Cells["Precio Unitario"].Value);

                row.Cells["Subtotal"].Value = cantidad * precio;
            }

            CalcularTotal();

        }

        private void btnGuardarCompraInsumos_Click(object sender, EventArgs e)
        {
            BE.CompraInsumo compra = new BE.CompraInsumo();

            
            compra.idProveedor = (BE.Proveedor)cmbProveedorInsumos.SelectedItem;

            compra.fecha = dtFehcaInsumos.Value;
            compra.comprobante = txtComprobanteInsumos.Text;
            compra.total = Convert.ToDecimal(lblTotalCompra.Text);

            List<BE.DetalleCompra> listaDetalles = new List<BE.DetalleCompra>();

            foreach (DataGridViewRow row in datagridCompraInsumos.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["Insumo"].Value == null) continue;

                BE.DetalleCompra detalle = new BE.DetalleCompra();

                detalle.descripcion = row.Cells["Insumo"].Value.ToString();
                detalle.cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                detalle.precioUnitario = Convert.ToDecimal(row.Cells["Precio Unitario"].Value);
                detalle.subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);

                listaDetalles.Add(detalle);
            }

            compra.detalleCompras = listaDetalles;

            string resultado = bllCompraInsumo.GuardarCompra(compra);

            if (resultado == "OK")
            {
                MessageBox.Show("Compra guardada correctamente");


                LimpiarTodo();
            }
            else
            {
                MessageBox.Show(resultado);
            }
        }

        private void LimpiarTodo()
        {
            cmbProveedorInsumos.SelectedIndex = -1;
            txtComprobanteInsumos.Clear();


            datagridCompraInsumos.Rows.Clear();
            lblTotalCompra.Text = "0.00";


        }

        private void CompraInsumos_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            cmbProveedorInsumos.DataSource = null;

            cmbProveedorInsumos.DataSource = bllProveedor.Listar();
            cmbProveedorInsumos.DisplayMember = "nombre";
            cmbProveedorInsumos.ValueMember = "idProveedor";

            cmbProveedorInsumos.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
