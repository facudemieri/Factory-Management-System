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
    public partial class ControlBusqueda : UserControl
    {
        public event EventHandler Buscar;

        public ControlBusqueda()
        {
            InitializeComponent();
            button1.Click += (s, e) => Buscar?.Invoke(this, EventArgs.Empty);
        }

        
        public string TextoLabel
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        
        public string TextoBoton
        {
            get { return button1.Text; }
            set { button1.Text = value; }
        }

        
        public object DataSource
        {
            get { return comboBox1.DataSource; }
            set { comboBox1.DataSource = value; }
        }

        public string DisplayMember
        {
            get { return comboBox1.DisplayMember; }
            set { comboBox1.DisplayMember = value; }
        }

        public string ValueMember
        {
            get { return comboBox1.ValueMember; }
            set { comboBox1.ValueMember = value; }
        }

        
        public object SelectedValue
        {
            get { return comboBox1.SelectedValue; }
        }

        public int SelectedIndex
        {
            get { return comboBox1.SelectedIndex; }
            set { comboBox1.SelectedIndex = value; }
        }

        public void Limpiar()
        {
            comboBox1.SelectedIndex = -1;
        }


    }
}
