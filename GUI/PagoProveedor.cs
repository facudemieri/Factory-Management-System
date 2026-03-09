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
    public partial class PagoProveedor : Form
    {

        BLL.PagoProveedor pagoProveedorBLL = new BLL.PagoProveedor();
        BLL.Proveedor proveedorBLL = new BLL.Proveedor();
        private object lblAvisoEstado;

        public PagoProveedor()
        {
            InitializeComponent();
            
        }

        private void ControlBusqueda1_Buscar(object sender, EventArgs e)
        {
            if (controlBusqueda1.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un proveedor");
                return;
            }

            int idProveedor = Convert.ToInt32(controlBusqueda1.SelectedValue);

            decimal saldoGlobal = proveedorBLL.ObtenerSaldoProveedor(idProveedor);
            lblSaldoPagos.Text = "Saldo Global: $"+ saldoGlobal.ToString("N2");
            DataTable dt = pagoProveedorBLL.ListarComprasPorProveedor(idProveedor);

            //if (dt.Rows.Count == 0)
            //{
            //    MessageBox.Show("El proveedor no tiene compras");
            //    datagridPagos.DataSource = null;
            //    return;
            //}

            datagridPagos.DataSource = dt;
        }

       

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            if (controlBusqueda1.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un proveedor");
                return;
            }

            int idProveedor = Convert.ToInt32(controlBusqueda1.SelectedValue);

            if (datagridPagos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una compra");
                return;
            }

            int idCompra = Convert.ToInt32(
                datagridPagos.CurrentRow.Cells["idCompra"].Value);

            if (!lblValidaNumero1.EsValido)
            {
                MessageBox.Show("Ingrese un importe válido mayor a 0");
                return;
            }

            decimal importe = lblValidaNumero1.Valor;

            
            if (string.IsNullOrWhiteSpace(cmbMetodoPagos.Text))
            {
                MessageBox.Show("Ingrese el método de pago");
                return;
            }

            
            BE.PagoProveedor pago = new BE.PagoProveedor();
            pago.Compra = idCompra;
            pago.importe = importe;
            pago.metodoPago = cmbMetodoPagos.Text.Trim();
            pago.fecha = DateTime.Now;

            

          
            string resultado = pagoProveedorBLL.RegistrarPago(pago);

            if (resultado == "OK")
            {
                MessageBox.Show("Pago registrado correctamente");
                
                
                datagridPagos.DataSource = pagoProveedorBLL.ListarComprasPorProveedor(idProveedor);

                
                decimal saldoGlobal = proveedorBLL.ObtenerSaldoProveedor(idProveedor);
                lblSaldoPagos.Text = "Saldo Global: $" + saldoGlobal.ToString("N2");

                lblValidaNumero1.Limpiar();
                cmbMetodoPagos.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(resultado);
            }
        }

        private void PagoProveedor_Load(object sender, EventArgs e)
        {
            controlBusqueda1.DataSource = proveedorBLL.Listar();
            controlBusqueda1.DisplayMember = "nombre";
            controlBusqueda1.ValueMember = "idProveedor";
            controlBusqueda1.SelectedIndex = -1;

            controlBusqueda1.Buscar += ControlBusqueda1_Buscar;
            datagridPagos.SelectionChanged += datagridPagos_SelectionChanged;
        }

        private void datagridPagos_SelectionChanged(object sender, EventArgs e)
        {
            
            if (datagridPagos.Focused && datagridPagos.CurrentRow != null)
            {
                bool pagado = Convert.ToBoolean(datagridPagos.CurrentRow.Cells["Pagado"].Value);
                int idCompra = Convert.ToInt32(datagridPagos.CurrentRow.Cells["idCompra"].Value);

                decimal totalCompra = pagoProveedorBLL.ObtenerTotalCompra(idCompra);
                decimal totalPagado = pagoProveedorBLL.ObtenerTotalPagado(idCompra);
                decimal saldoPendiente = totalCompra - totalPagado;

                
                btnRegistrarPago.Enabled = !pagado;

                lblTotalPagos.Text = $"Saldo de la Compra: ${saldoPendiente:N2}";


                if (pagado)
                {
                    lblAviso.Text = "Esta compra ya fue abonada";
                    lblAviso.ForeColor = Color.Red;
                    lblAviso.Visible = true;
                    
                }
                else
                {
                    lblAviso.Visible = false;
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
