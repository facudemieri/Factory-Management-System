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
    public partial class Pedido : Form
    {

        BLL.Producto bllProducto = new BLL.Producto();
        BLL.Cliente bllCliente = new BLL.Cliente();
        private int? idPedido = null;
        private bool modoEdicion = false;
        public Pedido()
        {
            InitializeComponent();
            ConfigurarDataGrid();
            labelEstadoControl1.Estado = "Pendiente";
            modoEdicion=false;
        }

        public Pedido(int idPedido)
        {
            InitializeComponent();
            ConfigurarDataGrid();

            this.idPedido = idPedido;
            modoEdicion = true;
            labelEstadoControl1.Estado = "Pendiente";
            CargarPedido();
        }

        private void CargarPedido()
        {
            BLL.Pedido bllPedido = new BLL.Pedido();

            BE.Pedido pedido = bllPedido.ObtenerPedidoCompleto(idPedido.Value);

            
            cmbClientePedido.SelectedValue = pedido.idcliente;
            dateTimePedido.Value = pedido.fecha;
            txtObservaciones.Text = pedido.observacion;

            datagridArticulos.Rows.Clear();

            foreach (var detalle in pedido.detalles)
            {
                int fila = datagridArticulos.Rows.Add();

                datagridArticulos.Rows[fila].Cells["Producto"].Value = detalle.producto;
                datagridArticulos.Rows[fila].Cells["Color"].Value = detalle.color;
                datagridArticulos.Rows[fila].Cells["Cantidad"].Value = detalle.cantidad;

                
                Dictionary<int, int> talles = new Dictionary<int, int>();

                foreach (var talle in detalle.talles)
                {
                    talles.Add(talle.talle, talle.cantidad);
                }

                datagridArticulos.Rows[fila].Tag = talles;
            }
        }

        private void ConfigurarDataGrid()
        {
            datagridArticulos.Columns.Clear();
            datagridArticulos.AllowUserToAddRows = false;

            
            DataGridViewComboBoxColumn colProducto = new DataGridViewComboBoxColumn();
            colProducto.HeaderText = "Producto";
            colProducto.Name = "Producto";
            colProducto.DataSource = bllProducto.Listar();
            colProducto.DisplayMember = "nombreModelo";
            colProducto.ValueMember = "idProducto";
            colProducto.Width = 150;
            datagridArticulos.Columns.Add(colProducto);

            
            DataGridViewTextBoxColumn colColor = new DataGridViewTextBoxColumn();
            colColor.HeaderText = "Color";
            colColor.Name = "Color";
            colColor.Width = 100;
            datagridArticulos.Columns.Add(colColor);

            
            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "Cantidad";
            colCantidad.Width = 80;
            datagridArticulos.Columns.Add(colCantidad);

            
            DataGridViewButtonColumn colTalles = new DataGridViewButtonColumn();
            colTalles.HeaderText = "Talles";
            colTalles.Text = "Asignar";
            colTalles.UseColumnTextForButtonValue = true;
            colTalles.Width = 80;
            datagridArticulos.Columns.Add(colTalles);

            
            DataGridViewButtonColumn colEliminar = new DataGridViewButtonColumn();
            colEliminar.HeaderText = "X";
            colEliminar.Text = "Eliminar";
            colEliminar.UseColumnTextForButtonValue = true;
            colEliminar.Width = 70;
            datagridArticulos.Columns.Add(colEliminar);
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            cmbClientePedido.DataSource = null;
            cmbClientePedido.DataSource = bllCliente.ListarClientes();
            cmbClientePedido.DisplayMember = "nombre";
            cmbClientePedido.ValueMember = "idCliente";
            cmbClientePedido.SelectedIndex = -1;
        }

        void LimpiarCampos()
        {
            txtObservaciones.Clear();
            dateTimePedido.Value = DateTime.Now;
            cmbClientePedido.SelectedIndex = -1;
            datagridArticulos.Rows.Clear();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            datagridArticulos.Rows.Add();
        }

        private bool ValidarDetalles()
        {
            if (datagridArticulos.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un detalle.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            foreach (DataGridViewRow fila in datagridArticulos.Rows)
            {
                
                if (fila.Cells["Producto"].Value == null)
                {
                    MessageBox.Show("Hay un detalle sin producto.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return false;
                }

                
                if (fila.Cells["Cantidad"].Value == null ||
                    !int.TryParse(fila.Cells["Cantidad"].Value.ToString(), out int cantidad) ||
                    cantidad <= 0)
                {
                    MessageBox.Show("Cantidad inválida en un detalle.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return false;
                }

                
                var talles = fila.Tag as Dictionary<int, int>;

                if (talles == null || talles.Count == 0)
                {
                    MessageBox.Show("Hay un detalle sin talles cargados.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return false;
                }

                int suma = talles.Values.Sum();

                if (suma != cantidad)
                {
                    MessageBox.Show("La suma de talles no coincide con la cantidad total.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void datagridArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            
            if (datagridArticulos.Columns[e.ColumnIndex].HeaderText == "Talles")
            {
                int cantidad = 0;

                if (datagridArticulos.Rows[e.RowIndex].Cells["Cantidad"].Value != null)
                {
                    int.TryParse(datagridArticulos.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString(),out cantidad);
                }

                if (cantidad <= 0)
                {
                    MessageBox.Show("Primero debe ingresar la cantidad.");
                    return;
                }
                Dictionary<int, int> tallesExistentes = datagridArticulos.Rows[e.RowIndex].Tag as Dictionary<int, int>;
                CargarTalles cargarTalles = new CargarTalles(cantidad);

                if (cargarTalles.ShowDialog() == DialogResult.OK)
                {
                    var talles = cargarTalles.TallesSeleccionados;

                    
                    datagridArticulos.Rows[e.RowIndex].Tag = talles;

                    MessageBox.Show("Talles asignados correctamente.");
                }
            }

            
            if (datagridArticulos.Columns[e.ColumnIndex].HeaderText == "X")
            {
                datagridArticulos.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            if(!ValidarDetalles())
            {
                return;
            }
            try
            {
                if (cmbClientePedido.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un cliente.");
                    return;
                }

                BE.Pedido pedido = ArmarObjetoPedidoDesdeForm();

                BLL.Pedido bllPedido = new BLL.Pedido();

                if (modoEdicion)
                {
                    pedido.idPedido = idPedido.Value;
                    bllPedido.ModificarPedido(pedido);
                    MessageBox.Show("Pedido modificado correctamente.");
                }
                else
                {
                    bllPedido.GuardarPedido(pedido);
                    MessageBox.Show("Pedido guardado correctamente.");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private BE.Pedido ArmarObjetoPedidoDesdeForm()
        {
            BE.Pedido pedido = new BE.Pedido();

            pedido.idcliente = Convert.ToInt32(cmbClientePedido.SelectedValue);
            pedido.fecha = dateTimePedido.Value;
            pedido.observacion = txtObservaciones.Text;

            foreach (DataGridViewRow fila in datagridArticulos.Rows)
            {
                if (fila.IsNewRow) continue;

                BE.DetallePedido detalle = new BE.DetallePedido();

                detalle.producto = Convert.ToInt32(fila.Cells["Producto"].Value);
                detalle.color = fila.Cells["Color"].Value?.ToString();
                detalle.cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);

                var talles = fila.Tag as Dictionary<int, int>;

                foreach (var item in talles)
                {
                    BE.DetallePedidoTalle talle = new BE.DetallePedidoTalle();

                    talle.talle = item.Key;
                    talle.cantidad = item.Value;

                    detalle.talles.Add(talle);
                }

                pedido.detalles.Add(detalle);
            }

            return pedido;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
