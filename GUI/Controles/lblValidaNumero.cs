using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Controles
{
    public partial class lblValidaNumero : UserControl
    {
        public lblValidaNumero()
        {
            InitializeComponent();
            txtNumero.KeyPress += SoloNumero;
        }

        public string TextoLabel
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public decimal Valor
        {
            get
            {
                decimal.TryParse(txtNumero.Text, out decimal valor);
                return valor;
            }
        }

        public bool EsValido
        {
            get
            {
                return decimal.TryParse(txtNumero.Text, out decimal v) && v > 0;
            }
        }

        public void Limpiar()
        {
            txtNumero.Clear();
        }

        private void SoloNumero(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            if (e.KeyChar == ',' && !txtNumero.Text.Contains(","))
                return;

            e.Handled = true;
        }
    }
}
