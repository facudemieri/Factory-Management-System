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
    public partial class Clientes : Form
    {
        BLL.Cliente bllCliente = new BLL.Cliente();
        public Clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCli_Click(object sender, EventArgs e)
        {
            try
            {
                BE.Cliente cliente = new BE.Cliente
                {
                    nombre = txtNombreCli.Text.Trim(),
                    apellido = txtApellido.Text.Trim(),
                    telefono = txtTelefonoCli.Text.Trim(),
                    email = txtEmailCli.Text.Trim()
                };

                int fa = bllCliente.AltaCliente(cliente);

                if (fa > 0)
                {
                    MessageBox.Show("Cliente agregado correctamente.");
                    ActualizarDataGrid();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditarCli_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lblIDcli.Text))
                {
                    MessageBox.Show("Seleccione un cliente.");
                    return;
                }

                BE.Cliente cliente = new BE.Cliente
                {
                    idCliente = int.Parse(lblIDcli.Text),
                    nombre = txtNombreCli.Text.Trim(),
                    apellido = txtApellido.Text.Trim(),
                    telefono = txtTelefonoCli.Text.Trim(),
                    email = txtEmailCli.Text.Trim()
                };

                int fa = bllCliente.ModificarCliente(cliente);

                if (fa > 0)
                {
                    MessageBox.Show("Cliente modificado correctamente.");
                    ActualizarDataGrid();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();

            datagridCli.Columns["idCliente"].ReadOnly = true;
            datagridCli.Columns["idCliente"].Visible = false;

            datagridCli.CurrentCellDirtyStateChanged += DatagridCli_CurrentCellDirtyStateChanged;
            datagridCli.CellValueChanged += DatagridCli_CellValueChanged;
        }

        void LimpiarCampos()
        {
            lblIDcli.Text = "...";
            txtNombreCli.Text = "";
            txtApellido.Text = "";
            txtEmailCli.Text = "";
            txtTelefonoCli.Text = "";
        }

        private void DatagridCli_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            if (datagridCli.Columns[e.ColumnIndex].Name == "activo")
            {
                int id = Convert.ToInt32(datagridCli.Rows[e.RowIndex].Cells["idCliente"].Value);
                bool estado = Convert.ToBoolean(datagridCli.Rows[e.RowIndex].Cells["activo"].Value);

                string resultado = bllCliente.CambiarEstado(id, estado);

                if (resultado != "OK")
                {
                    MessageBox.Show(resultado);
                    ActualizarDataGrid();
                }
            }
        }

        private void DatagridCli_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (datagridCli.IsCurrentCellDirty)
            {
                datagridCli.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void ActualizarDataGrid()
        {
            datagridCli.DataSource = null;
            datagridCli.DataSource = bllCliente.ListarClientes();
        }

        private void datagridCli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridCli.CurrentRow == null) { return; }

            lblIDcli.Text = datagridCli.CurrentRow.Cells["idCliente"].Value.ToString();
            txtNombreCli.Text = datagridCli.CurrentRow.Cells["nombre"].Value.ToString();
            txtApellido.Text = datagridCli.CurrentRow.Cells["apellido"].Value.ToString();
            txtEmailCli.Text = datagridCli.CurrentRow.Cells["email"].Value.ToString();
            txtTelefonoCli.Text = datagridCli.CurrentRow.Cells["telefono"].Value.ToString();
        }
    }
}
