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
    public partial class CrearUsuario : Form
    {

        BLL.Usuario usuarioBLL = new BLL.Usuario();
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if ((!labelTextoBoxValidar2.EsValido) && (!labelTextoBoxValidar1.EsValido))
                {
                    MessageBox.Show("Debe completar todos los campos.");
                    return;
                }

                BE.Usuario usuario = new BE.Usuario();
                usuario.nombreUsuario = labelTextoBoxValidar2.Texto.Trim();
                usuario.contraseñaHash = labelTextoBoxValidar1.Texto.Trim();

                string resultado = usuarioBLL.AltaUsuario(usuario);

                if (resultado == "OK")
                {
                    MessageBox.Show("Usuario creado correctamente.");                                    
                    LimpiarCampos();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(resultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            labelTextoBoxValidar1.Limpiar();
            labelTextoBoxValidar2.Limpiar();

        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            labelTextoBoxValidar2.Focus();
            labelTextoBoxValidar1.esContraseña = true;
        }
    }
}

