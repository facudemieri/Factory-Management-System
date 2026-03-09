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
    public partial class Proveedores : Form
    {

        Proveedor proveedorBLL = new Proveedor();
        public Proveedores()
        {
            InitializeComponent();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProveedor.Text))
            {
                MessageBox.Show("El nombre del proveedor es obligatorio.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtApellidoProveedor.Text))
            {
                MessageBox.Show("El apellido del proveedor es obligatorio.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTelefonoProveedor.Text))
            {
                MessageBox.Show("El telefono del proveedor es obligatorio.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmailProveedor.Text))
            {
                MessageBox.Show("El email del proveedor es obligatorio.");
                return;
            }

            BE.Proveedor proveedor = new BE.Proveedor();

            proveedor.nombre = txtNombreProveedor.Text.Trim();
            proveedor.apellido = txtApellidoProveedor.Text.Trim();
            proveedor.telefono = txtTelefonoProveedor.Text.Trim();
            proveedor.email = txtEmailProveedor.Text.Trim();

            bool resultado = proveedorBLL.AltaProveedor(proveedor);
            
            if (resultado == true)
            {
                MessageBox.Show("Proveedor agregado correctamente.");
                LimpiarCampos();
                CargarProveedores();
            }
            else
            {
                MessageBox.Show("Error al guardar.");
            }

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            int idProveedor = proveedorBLL.ObtenerUltNroProveedor() + 1;
            lblIDproveedor.Text = idProveedor.ToString();
            CargarProveedores();
            datagridProveedor.CurrentCellDirtyStateChanged += datagridProveedor_CurrentCellDirtyStateChanged;
            datagridProveedor.CellValueChanged += datagridProveedor_CellValueChanged;
        }

        private void datagridProveedor_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (datagridProveedor.IsCurrentCellDirty)
            {
                datagridProveedor.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void CargarProveedores()
        {
            datagridProveedor.DataSource = null;
            datagridProveedor.DataSource = proveedorBLL.Listar();
        }

        private void LimpiarCampos()
        {
            lblIDproveedor.Text = "";
            txtNombreProveedor.Text = "";
            txtApellidoProveedor.Text = "";
            txtTelefonoProveedor.Text = "";
            txtEmailProveedor.Text = "";

        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblIDproveedor.Text))
            {
                MessageBox.Show("Seleccione un proveedor.");
                return;
            }

            BE.Proveedor proveedor = new BE.Proveedor();

            proveedor.nombre = txtNombreProveedor.Text.Trim();
            proveedor.apellido = txtApellidoProveedor.Text.Trim();
            proveedor.telefono = txtTelefonoProveedor.Text.Trim();
            proveedor.email = txtEmailProveedor.Text.Trim();

            bool resultado = proveedorBLL.ModificarProveedor(proveedor);
            
            if (resultado == true)
            {
                MessageBox.Show("Proveedor agregado correctamente.");
                LimpiarCampos();
                CargarProveedores();
            }
            else
            {
                MessageBox.Show("Error al guardar.");
            }
        }

        private void datagridProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridProveedor.CurrentRow == null)
                return;

            lblIDproveedor.Text = datagridProveedor.CurrentRow.Cells["idProveedor"].Value.ToString();
            txtNombreProveedor.Text = datagridProveedor.CurrentRow.Cells["nombre"].Value.ToString();
            txtApellidoProveedor.Text = datagridProveedor.CurrentRow.Cells["apellido"].Value.ToString();
            txtTelefonoProveedor.Text = datagridProveedor.CurrentRow.Cells["telefono"].Value.ToString();
            txtEmailProveedor.Text = datagridProveedor.CurrentRow.Cells["email"].Value.ToString();
        }

        private void datagridProveedor_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (datagridProveedor.Columns[e.ColumnIndex].Name == "activo")
            {
                int id = Convert.ToInt32(datagridProveedor.Rows[e.RowIndex].Cells["idProveedor"].Value);
                bool estado = Convert.ToBoolean(datagridProveedor.Rows[e.RowIndex].Cells["activo"].Value);

                string resultado = proveedorBLL.CambiarEstado(id, estado);

                if (resultado != "OK")
                {
                    MessageBox.Show(resultado);
                    CargarProveedores(); 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            this.Close();
        }
    }
}
