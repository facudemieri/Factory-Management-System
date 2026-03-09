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
    public partial class CargarTalles : Form
    {
        int cantidadTotal;
        public Dictionary<int, int> TallesSeleccionados { get; private set; }

        public CargarTalles(int cantidad, Dictionary<int, int> tallesExistentes = null)
        {
            InitializeComponent();

            cantidadTotal = cantidad;
            TallesSeleccionados = new Dictionary<int, int>();

            ConfigurarDataGrid();
            lblCantidadTotal.Text = "Cantidad Total: " + cantidadTotal;

            if (tallesExistentes != null)
            {
                foreach (DataGridViewRow fila in dgvTalles.Rows)
                {
                    int talle = Convert.ToInt32(fila.Cells["Talle"].Value);

                    if (tallesExistentes.ContainsKey(talle))
                    {
                        fila.Cells["Cantidad"].Value = tallesExistentes[talle];
                    }
                }

                CalcularSuma();
            }
        }


        private void ConfigurarDataGrid()
        {
            dgvTalles.Columns.Clear();
            dgvTalles.AllowUserToAddRows = false;

            
            DataGridViewTextBoxColumn colTalle = new DataGridViewTextBoxColumn();
            colTalle.HeaderText = "Talle";
            colTalle.Name = "Talle";
            colTalle.ReadOnly = true;   

            dgvTalles.Columns.Add(colTalle);

            
            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "Cantidad";

            dgvTalles.Columns.Add(colCantidad);

            for (int i = 35; i <= 45; i++)
            {
                dgvTalles.Rows.Add(i, 0);
            }
        }

       

        private void dgvTalles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalcularSuma();
        }

        private void CalcularSuma()
        {
            int suma = 0;

            foreach (DataGridViewRow fila in dgvTalles.Rows)
            {
                if (fila.Cells["Cantidad"].Value != null)
                {
                    int valor;
                    if (int.TryParse(fila.Cells["Cantidad"].Value.ToString(), out valor))
                    {
                        suma += valor;
                    }
                }
            }

            lblSumaActual.Text = "Suma actual: " + suma;

            if (suma == cantidadTotal)
                lblSumaActual.ForeColor = Color.Green;
            else
                lblSumaActual.ForeColor = Color.Red;
        }

 
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            int suma = 0;
            TallesSeleccionados.Clear();

            foreach (DataGridViewRow fila in dgvTalles.Rows)
            {
                int talle = Convert.ToInt32(fila.Cells["Talle"].Value);
                int cantidad = 0;

                if (fila.Cells["Cantidad"].Value != null)
                    int.TryParse(fila.Cells["Cantidad"].Value.ToString(), out cantidad);

                if (cantidad > 0)
                {
                    TallesSeleccionados.Add(talle, cantidad);
                    suma += cantidad;
                }
            }

            if (suma != cantidadTotal)
            {
                MessageBox.Show("La suma de talles debe ser igual a la cantidad total.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
