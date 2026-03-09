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
    public partial class Cobros : Form
    {
        BLL.Venta ventaBLL = new BLL.Venta();
        BLL.Cobro cobroBLL = new BLL.Cobro();
        BLL.Cliente clienteBLL = new BLL.Cliente();
        public Cobros()
        {
            InitializeComponent();
        }

        private void btnRegistrarCobro_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (datagridVentasCobros.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una venta para cobrar.");
                    return;
                }
                decimal importe = lblValidaNumero1.Valor;

                if (!lblValidaNumero1.EsValido) 
                {
                    MessageBox.Show("Ingrese un monto válido mayor a cero.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(cmbMetodoCobros.Text))
                {
                    MessageBox.Show("Seleccione un método de pago.");
                    return;
                }

                
                BE.Cobro nuevoCobro = new BE.Cobro();
                nuevoCobro.idventa = Convert.ToInt32(datagridVentasCobros.CurrentRow.Cells["idVenta"].Value);
                nuevoCobro.cliente = ObtenerClienteSeleccionado();
                nuevoCobro.importe = importe; 
                nuevoCobro.metodoPago = cmbMetodoCobros.Text;

                
                cobroBLL.RegistrarCobro(nuevoCobro);

                MessageBox.Show("Cobro registrado con éxito.");

                
                lblValidaNumero1.Limpiar();
                CargarDataGrid();
                cmbMetodoCobros.SelectedIndex = -1;
                ActualizarLabelsSaldo();
                lblPendienteVenta.Text = "Pendiente: $0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarLabelsSaldo()
        {
            int idCliente = ObtenerClienteSeleccionado();

            
            if (idCliente <= 0)
            {
                lblSaldoCobros.Text = "Saldo Deuda: $0.00";
                btnRegistrarCobro.Enabled = false;
                return;
            }

            DataTable dt = clienteBLL.ListarClientes();
            
            DataRow cliente = dt.AsEnumerable().FirstOrDefault(c => Convert.ToInt32(c["idCliente"]) == idCliente);

            if (cliente != null)
            {
                lblSaldoCobros.Text = $"Saldo Deuda: ${Convert.ToDecimal(cliente["SaldoDeuda"]):N2}";
            }
        }

        private void Cobros_Load(object sender, EventArgs e)
        {
            controlBusqueda1.DataSource =  clienteBLL.ListarClientes();
            controlBusqueda1.DisplayMember = "Nombre";
            controlBusqueda1.ValueMember = "IdCliente";
            controlBusqueda1.SelectedIndex = -1;

            controlBusqueda1.Buscar += ControlBusqueda1_Buscar;

            lblSaldoCobros.Text = "Saldo Deuda: $0.00";
            lblTotalCobro.Text = "Total Venta: $0.00";
        }

        private void ControlBusqueda1_Buscar(object sender, EventArgs e)
        {
            CargarDataGrid();
            ActualizarLabelsSaldo();
        }

        private void CargarDataGrid()
        {
            int idCliente = ObtenerClienteSeleccionado();
            if (idCliente > 0)
            {
                datagridVentasCobros.DataSource = ventaBLL.ListarVentas(idCliente);            
                datagridVentasCobros.ClearSelection();
                btnRegistrarCobro.Enabled = false;
                lblTotalCobro.Text = "Total Venta: $0.00";
            }
        }

        private int ObtenerClienteSeleccionado()
        {
            if (controlBusqueda1.SelectedIndex == -1) { return 0; }
            return Convert.ToInt32(controlBusqueda1.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datagridVentasCobros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridVentasCobros.CurrentRow != null)
            {
                int idVenta = Convert.ToInt32(datagridVentasCobros.CurrentRow.Cells["idVenta"].Value);
                decimal totalVenta = Convert.ToDecimal(datagridVentasCobros.CurrentRow.Cells["Total"].Value);


                decimal pagado = cobroBLL.ObtenerSaldoPendiente(idVenta);
                decimal pendiente = totalVenta - pagado;

                lblTotalCobro.Text = $"Total Venta: ${totalVenta:N2}";
                lblPendienteVenta.Text = $"Pendiente de esta factura: ${pendiente:N2}";                                         
            }
            
        }

        private void datagridVentasCobros_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridVentasCobros.Focused && datagridVentasCobros.CurrentRow != null)
            {
                bool estaPagada = Convert.ToBoolean(datagridVentasCobros.CurrentRow.Cells["Pagado"].Value);
                btnRegistrarCobro.Enabled = !estaPagada;

                
                decimal total = Convert.ToDecimal(datagridVentasCobros.CurrentRow.Cells["Total"].Value);
                lblTotalCobro.Text = $"Total Venta: ${total:N2}";
            }
        }
    }
}
