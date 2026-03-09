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
    public partial class labelTextoBoxValidar : UserControl 
    { 
        public labelTextoBoxValidar() 
        { 
            InitializeComponent(); 
            textBox1.TextChanged += (s, e) => ActualizarVisual();
        } 
        public string TextoLabel 
        { 
            get { return label1.Text; } set { label1.Text = value; } 
        } 
        public string Texto 
        { 
            get { return textBox1.Text; } set { textBox1.Text = value; } 
        } 
        public bool EsValido 
        { 
            get { bool valido = !string.IsNullOrEmpty(textBox1.Text); ActualizarVisual(); return valido; } 
        }

        private void ActualizarVisual()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                label1.ForeColor = Color.Red;
            }
            else
            {
                label1.ForeColor = Color.Black;
            }
        }

        public void Limpiar() 
        { 
            textBox1.Clear(); 
            ActualizarVisual();
        } 
        public bool esContraseña 
        { 
            set { textBox1.UseSystemPasswordChar = value; } 
        } 
        private void validar(object sender, EventArgs e) 
        { 
            
        } 
    }
}
