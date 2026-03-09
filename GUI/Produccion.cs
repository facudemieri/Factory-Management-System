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
    public partial class Produccion : Form
    {
        BLL.Cliente clienteBll = new BLL.Cliente();
        BLL.Produccion produccionBll = new BLL.Produccion();
        public Produccion()
        {
            InitializeComponent();
        }

        private void Produccion_Load(object sender, EventArgs e)
        {
            controlBusqueda1.DataSource = clienteBll.ListarClientes();
            controlBusqueda1.DisplayMember = "Nombre";
            controlBusqueda1.ValueMember = "IdCliente";
            controlBusqueda1.SelectedIndex = -1;

            controlBusqueda1.Buscar += ControlBusqueda1_Buscar;

            
        }

        private void CargarGrid()
        {
            int idCliente = ObtenerClienteSeleccionado();

            datagridPedidosAprobados.DataSource = produccionBll.ListarAprobados(idCliente);
            datagridPedidosenProd.DataSource = produccionBll.ListarEnProduccion(idCliente);
            AgregarDiasEnProduccion();
            PintarGrid();
            ActualizarDashBoard();
        }

        private void ActualizarDashBoard()
        {
            int idCliente = ObtenerClienteSeleccionado();

            var aprobados = produccionBll.ListarAprobados(idCliente);
            var enProduccion = produccionBll.ListarEnProduccion(idCliente);

            lblCantAprobados.Text = "Aprobados: " + aprobados.Rows.Count;
            lblCantEnProduccion.Text = "En Producción: " + enProduccion.Rows.Count;

            lblFinalizadosHoy.Text = "Finalizados Hoy: " + produccionBll.ObtenerFinalizadosHoy();
        }

        private void PintarGrid()
        {
            foreach (DataGridViewRow row in datagridPedidosAprobados.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.LightBlue;
            }

            foreach (DataGridViewRow row in datagridPedidosenProd.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }

        private void AgregarDiasEnProduccion()
        {
            //datagridPedidosenProd.Columns.Remove("Dias");
            
            if (!datagridPedidosenProd.Columns.Contains("Dias"))
            {
                datagridPedidosenProd.Columns.Add("Dias", "Días");
            }

            foreach (DataGridViewRow row in datagridPedidosenProd.Rows)
            {
                if (row.Cells["FechaInicio"].Value != null)
                {
                    DateTime fechaInicio = Convert.ToDateTime(row.Cells["FechaInicio"].Value);

                    int dias = (DateTime.Now - fechaInicio).Days;

                    row.Cells["Dias"].Value = dias;
                }
            }
        }

        private int ObtenerClienteSeleccionado()
        {
            if (controlBusqueda1.SelectedIndex == -1) { return 0; }
            return Convert.ToInt32(controlBusqueda1.SelectedValue);
        }

        private void ControlBusqueda1_Buscar(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnIniciarProduccion_Click(object sender, EventArgs e)
        {
            if (datagridPedidosAprobados.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un pedido.");
                return;
            }

            int idPedido = Convert.ToInt32(datagridPedidosAprobados.CurrentRow.Cells["idPedido"].Value);

            try
            {
                produccionBll.IniciarProduccion(idPedido);
                MessageBox.Show("Producción iniciada correctamente.");
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFinalizarProduccion_Click(object sender, EventArgs e)
        {
            if (datagridPedidosenProd.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una producción.");
                return;
            }

            int idProduccion = Convert.ToInt32(datagridPedidosenProd.CurrentRow.Cells["idProduccion"].Value);
            int idPedido = Convert.ToInt32(datagridPedidosenProd.CurrentRow.Cells["idPedido"].Value);
            try
            {
                produccionBll.FinalizarProduccion(idProduccion, idPedido);
                MessageBox.Show("Producción finalizada correctamente.");
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
