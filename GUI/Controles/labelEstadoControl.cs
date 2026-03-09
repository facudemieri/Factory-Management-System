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
    public partial class labelEstadoControl : UserControl
    {
        public labelEstadoControl()
        {
            InitializeComponent();
        }

        public string Estado
        {
            get { return lblEstadoCU.Text; }
            set
            {
                lblEstadoCU.Text = value;
                cambiarColor(value);
            }
        }

        private void cambiarColor(string estado)
        {
            switch (estado)
            {
                case "Pendiente":
                    lblEstadoCU.BackColor = Color.Gold;
                    break;

                case "Aprobado":
                    lblEstadoCU.BackColor = Color.LightGreen;
                    break;

                case "EnProduccion":
                    lblEstadoCU.BackColor = Color.LightBlue;
                    break;

                case "Finalizado":
                    lblEstadoCU.BackColor = Color.Gray;
                    break;

                default:
                    lblEstadoCU.BackColor = Color.White;
                    break;

            }
        }
    }
}
