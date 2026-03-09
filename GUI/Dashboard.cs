using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Dashboard : Form
    {
        BLL.Reportes bllReporte = new BLL.Reportes();
        BLL.Sistema sys = new BLL.Sistema();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Proveedores proveedoresForm = new Proveedores();
            proveedoresForm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Producto productoForm = new Producto();
            productoForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea cerrar la sesión?", "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {

                Login loginForm = new Login();
                loginForm.Show();

                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clientes clientesForm = new Clientes();
            clientesForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cobros cobrosForm = new Cobros();
            cobrosForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PagoProveedor pagoProveedor = new PagoProveedor();
            pagoProveedor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ventas ventasForm = new Ventas();
            ventasForm.Show();
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            Produccion produccionForm = new Produccion();
            produccionForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CompraInsumos compraInsumosForm = new CompraInsumos();  
            compraInsumosForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PedidoBusqueda pedidoBusquedaForm = new PedidoBusqueda();
            pedidoBusquedaForm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            cmbReporteDASH.Items.Add("Ventas Diarias");
            cmbReporteDASH.Items.Add("Cobros del Día");
            cmbReporteDASH.Items.Add("Clientes Morosos");
            cmbReporteDASH.Items.Add("Caja por Métodos");
            cmbReporteDASH.Items.Add("Compras del Dia");
            cmbReporteDASH.Items.Add("Deuda Proveedores");

            ActualizarInfoSistema();

        }

        private void btnGenerarReporteDash_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbReporteDASH.SelectedIndex == -1) return;

                
                DataTable dt = bllReporte.ObtenerDatosReporte(cmbReporteDASH.Text, dateTimeDash.Value);

                dataGridView1.DataSource = dt;

                ActualizarInfoSistema();

                if (dt != null && dt.Rows.Count > 0)
                {                    
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;                    
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExportarXMLDash_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dt)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                string nombreReporte = cmbReporteDASH.Text.Replace(" ", "_");
                string fechaActual = DateTime.Now.ToString("yyyy-MM-dd");

                sfd.FileName = $"{nombreReporte}_{fechaActual}.xml";
                sfd.Filter = "Archivos XML (*.xml)|*.xml";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    dt = (DataTable)dataGridView1.DataSource;
                    dt.TableName = "Reporte";
                    dt.WriteXml(sfd.FileName, XmlWriteMode.WriteSchema);
                    
                    DialogResult respuesta = MessageBox.Show("Archivo exportado. ¿Desea abrirlo ahora?", "Reporte Generado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        
                        sys.AbrirArchivo(sfd.FileName); 
                    }
                }
            }
            else
            {
                MessageBox.Show("Primero debe generar un reporte con datos.");
            }
        }

        private void ActualizarInfoSistema()
        {            
            lblDiagnostico.Text = $"Memoria: {sys.ObtenerUsoMemoria()} | Usuario: {Environment.UserName}";
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process actual = Process.GetCurrentProcess();
            TimeSpan duracion = DateTime.Now - actual.StartTime;
            
            MessageBox.Show($"Sesión finalizada. Duración total: {duracion.TotalMinutes:N2} minutos.");
        }
    }
}
