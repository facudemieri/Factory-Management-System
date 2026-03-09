using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BLL;

namespace GUI
{
    public partial class Login : Form
    {

        Usuario usuarioBLL = new Usuario();
        int intentos = 0;
        const int MAX_INTENTOS = 3;
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CrearUsuario crearUsuario = new CrearUsuario();
            crearUsuario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Debe completar todos los campos.", "Atención",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                bool acceso = usuarioBLL.Login(textBox1.Text.Trim(),
                                        textBox2.Text.Trim());

                if (acceso)
                {
                    MessageBox.Show("Bienvenido al sistema.", "Correcto",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    Dashboard frm = new Dashboard();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    intentos++;

                    MessageBox.Show("Usuario o contraseña incorrectos.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    if (intentos >= MAX_INTENTOS)
                    {
                        MessageBox.Show("Ha superado la cantidad de intentos permitidos.",
                                        "Sistema bloqueado",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Stop);

                        Application.Exit();
                    }

                    textBox2.Clear();
                    textBox2.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
