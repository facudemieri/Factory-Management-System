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
    public partial class PedidoBusqueda : Form
    {

        BLL.Pedido bllPedido = new BLL.Pedido();
        BLL.Cliente cliente = new BLL.Cliente();
        public PedidoBusqueda()
        {
            InitializeComponent();
        }

        private void btnNuevoPedi_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cmbClientePedi.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }
            int idCliente = Convert.ToInt32(cmbClientePedi.SelectedValue);
            string estado = cmbEstadoPedi.SelectedItem?.ToString();

            datagridPedidos.DataSource = bllPedido.ListarPedidos(idCliente, estado == "Todos" ? null : estado, dtDesde.Value, dtHasta.Value);
        }

        private void btnAprobarPedi_Click(object sender, EventArgs e)
        {
            if (datagridPedidos.CurrentRow == null) return;

            int idPedido = Convert.ToInt32(datagridPedidos.CurrentRow.Cells["idPedido"].Value);

            bllPedido.AprobarPedido(idPedido);

            MessageBox.Show("Pedido aprobado.");
            btnBuscar.PerformClick();
        }

        private void btnCancelarPedi_Click(object sender, EventArgs e)
        {
            if (datagridPedidos.CurrentRow == null) return;

            int idPedido = Convert.ToInt32(datagridPedidos.CurrentRow.Cells["idPedido"].Value);

            bllPedido.CancelarPedido(idPedido);

            MessageBox.Show("Pedido cancelado.");
            btnBuscar.PerformClick();
        }

        private void datagridPedidos_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridPedidos.CurrentRow == null) return;

            int idPedido = Convert.ToInt32(datagridPedidos.CurrentRow.Cells["idPedido"].Value);

            DataTable dt = bllPedido.TraerDetalle(idPedido);

            listBoxDetalles.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                listBoxDetalles.Items.Add($"{row["nombreModelo"]} - {row["Color"]} - {row["Cantidad"]} pares");
            }
        }

        private void btnEditarPedi_Click(object sender, EventArgs e)
        {
            if (datagridPedidos.CurrentRow == null) return;

            int idPedido = Convert.ToInt32(datagridPedidos.CurrentRow.Cells["idPedido"].Value);

            Pedido pedido = new Pedido(idPedido);
            pedido.ShowDialog();

            btnBuscar.PerformClick();
        }

        private void PedidoBusqueda_Load(object sender, EventArgs e)
        {
            cmbClientePedi.DataSource = null;
            cmbClientePedi.DataSource = cliente.ListarClientes();
            cmbClientePedi.DisplayMember = "Nombre";
            cmbClientePedi.ValueMember = "idCliente";

            cmbClientePedi.SelectedIndex = -1;

            cmbEstadoPedi.Items.Clear();
            cmbEstadoPedi.Items.Add("Todos");
            cmbEstadoPedi.Items.Add("Pendiente");
            cmbEstadoPedi.Items.Add("Aprobado");
            cmbEstadoPedi.Items.Add("Cancelado");

            cmbEstadoPedi.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
