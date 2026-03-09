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
    public partial class Ventas : Form
    {

        BLL.Cliente bllCliente = new BLL.Cliente();
        BLL.Venta bllVenta = new BLL.Venta();
        public Ventas()
        {
            InitializeComponent();
            
        }

        private void ControlBusqueda1_Buscar(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnIniciarProduccion_Click(object sender, EventArgs e)
        {
            if(datagridPedidosAprobados.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un pedido.");
                return;
            }

            int idPedido = Convert.ToInt32(datagridPedidosAprobados.CurrentRow.Cells["idPedido"].Value);

            try
            {
                bllVenta.GenerarVenta(idPedido);
                MessageBox.Show("Venta generada exitosamente.");
                CargarGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);  }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            controlBusqueda1.DataSource = bllCliente.ListarClientes();
            controlBusqueda1.DisplayMember = "Nombre";
            controlBusqueda1.ValueMember = "IdCliente";

            controlBusqueda1.SelectedIndex = -1;
            controlBusqueda1.Buscar += ControlBusqueda1_Buscar;

        }

        private void CargarGrid()
        {
            int idCliente = ObtenerClienteSeleccionado();
            datagridPedidosAprobados.DataSource = bllVenta.ListarFinalizadosNoFacturados(idCliente);
            dataGridView1.DataSource = bllVenta.ListarVentas(idCliente);
            PintarGrid();
            ActualizarDashBoard();
        }

        private void ActualizarDashBoard()
        {
            int idCliente = ObtenerClienteSeleccionado();
            var finalizadosNoFacturados = bllVenta.ListarFinalizadosNoFacturados(idCliente);
            lblVentasHoy.Text = "Ventas hoy: " + bllVenta.ObtenerVentasHoy();
            lblTotalFacturado.Text = "Total Facturado: $" + bllVenta.ObtenerTotalFacturadoHoy();
        }

        private void PintarGrid()
        {
            foreach(DataGridViewRow row in datagridPedidosAprobados.Rows) { row.DefaultCellStyle.BackColor = Color.LightGreen; }
            foreach (DataGridViewRow row in dataGridView1.Rows) { row.DefaultCellStyle.BackColor = Color.LightYellow; }
        }
        private int ObtenerClienteSeleccionado()
        {
            if(controlBusqueda1.SelectedIndex == -1) { return 0; }
            return Convert.ToInt32(controlBusqueda1.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
