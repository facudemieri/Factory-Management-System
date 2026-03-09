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
    public partial class Producto : Form
    {
        BLL.Producto bllProducto = new BLL.Producto();
        public Producto()
        {
            InitializeComponent();
        }

        private void btnAgregarCli_Click(object sender, EventArgs e)
        {
            try
            {
                decimal precio;

                if(!decimal.TryParse(txtPrecio.Text, out precio))
                {
                    MessageBox.Show("Ingrese un precio válido.");
                    return;
                }

                BE.Producto producto = new BE.Producto
                {
                    nombreModelo = txtNombreCli.Text,
                    precioVenta = precio,
                    
                };

                int fa = bllProducto.AltaProducto(producto);

                if (fa == 0) { MessageBox.Show("No se pudo agregar el producto");} else { MessageBox.Show("Producto agregado correctamente"); }
                ActualizarDataGrid();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarDataGrid()
        {
            datagridProductos.DataSource = null;
            datagridProductos.DataSource = bllProducto.Listar();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();

            datagridProductos.Columns["idProducto"].ReadOnly = true;
            datagridProductos.Columns["idProducto"].Visible = false;

            datagridProductos.CurrentCellDirtyStateChanged += datagridProductos_CurrentCellDirtyStateChanged;
            datagridProductos.CellValueChanged += datagridProductos_CellValueChanged;
        }

        private void datagridProductos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if(datagridProductos.IsCurrentCellDirty)
            {
                datagridProductos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        void LimpiarCampos()
        {
            lblIdProd.Text = "...";
            txtNombreCli.Text = string.Empty;
            txtPrecio.Text = string.Empty;
        }

        private void datagridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridProductos.CurrentRow == null) { return; }

            lblIdProd.Text = datagridProductos.CurrentRow.Cells["idProducto"].Value.ToString();
            txtNombreCli.Text = datagridProductos.CurrentRow.Cells["nombreModelo"].Value.ToString();
            txtPrecio.Text = datagridProductos.CurrentRow.Cells["precioVenta"].Value.ToString();    
        }

        private void btnEditarCli_Click(object sender, EventArgs e)
        {
            try
    {
                if (string.IsNullOrWhiteSpace(lblIdProd.Text))
                {
                    MessageBox.Show("Seleccione un producto para editar.");
                    return;
                }

                decimal precio;

                if (!decimal.TryParse(txtPrecio.Text, out precio))
                {
                    MessageBox.Show("Ingrese un precio válido.");
                    return;
                }

                BE.Producto producto = new BE.Producto
                {
                    idProducto = int.Parse(lblIdProd.Text), 
                    nombreModelo = txtNombreCli.Text,
                    precioVenta = precio
                };

                int fa = bllProducto.ModificarProducto(producto);

                if (fa == 0)
                    MessageBox.Show("No se pudo editar el producto.");
                else
                    MessageBox.Show("Producto editado correctamente.");

                ActualizarDataGrid();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void datagridProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) { return; }

            if (datagridProductos.Columns[e.ColumnIndex].Name == "activo")
            {
                int id = Convert.ToInt32(datagridProductos.Rows[e.RowIndex].Cells["idProducto"].Value);
                bool estado = Convert.ToBoolean(datagridProductos.Rows[e.RowIndex].Cells["activo"].Value);

                string resultado = bllProducto.CambiarEstado(id, estado);

                if (resultado != "OK")
                {
                    MessageBox.Show(resultado);
                    ActualizarDataGrid();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
