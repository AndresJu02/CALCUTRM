//using CALCUTRM.ServiceReference2;
using CALCUTRM.SERVICE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace CALCUTRM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private decimal trmActual = 0;
        private bool _formateando = false;
        private async void Form1_Load(object sender, EventArgs e)
        {
            bool enabled = await RemoteControl.IsEnabledAsync();
            if (!enabled)
            {
                MessageBox.Show("Esta aplicación ha sido deshabilitada por el administrador.");
                Application.Exit();
                return; // muy importante para evitar que el código siga
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Login_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(@"C:\Users\anses\Downloads\faviconTRM.ico");
        }
        private void txtIngMonto_TextChanged(object sender, EventArgs e)
        {
            string texto = txtIngMonto.Text.Replace(".", ","); // <- permite usar el punto

            if (decimal.TryParse(texto, out decimal montoUSD))
            {
                txtIngMonto.BackColor = Color.White;
            }
            else
            {
                txtIngMonto.BackColor = Color.LightCoral;
            }

        }
        private async void txtIngMonto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evita 'beep'
                btnConvertir.PerformClick(); // ejecuta la conversión
            }
        }


        private async void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtIngMonto.Text.Replace(".", ",");

                if (!decimal.TryParse(texto, out decimal montoUSD))
                {
                    lblResul.Text = "Monto inválido.";
                    return;
                }

                var trmService = new TrmService();
                decimal trmActual = await trmService.GetTRMAsync();

                decimal resultadoCOP = montoUSD * trmActual;

                lblActu.Text = $"TRM hoy: {trmActual:N2}\n\nÚltima conversión:\n\n{DateTime.Now:dd/MM/yyyy HH:mm:ss}";
                lblResul.Text = $"{resultadoCOP:N0} COP";
            }
            catch
            {
                lblResul.Text = "Error al obtener TRM";
            }
        }

        private void lblResul_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblResul.Text))
            {
                Clipboard.SetText(lblResul.Text);
                Toast.Show("¡Copiado!", 700);  // << duración en milisegundos (rápido)
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnActu_Click(object sender, EventArgs e)
        {
            try
            {
                var trmService = new TrmService();
                decimal trm = await trmService.GetTRMAsync();

                lblActu.Text = $"TRM hoy: {trm:N2}\n\n\n\nActualizado: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
            }
            catch
            {
                lblActu.Text = "Error al obtener TRM";
            }
        }


        private async void lblActu_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnActu2_Click(object sender, EventArgs e)
        {
            try
            {
                var trmService = new TrmService();
                decimal trm = await trmService.GetTRMAsync();

                lblActu2.Text = $"TRM hoy: {trm:N2}\n\n\n\nActualizado: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
            }
            catch
            {
                lblActu2.Text = "Error al obtener TRM";
            }
        }

        private void txtIngMonto2_TextChanged(object sender, EventArgs e)
        {
            string texto = txtIngMonto2.Text.Replace(".", ","); // <- permite usar el punto

            if (decimal.TryParse(texto, out decimal montoCOP))
            {
                txtIngMonto2.BackColor = Color.White;
            }
            else
            {
                txtIngMonto2.BackColor = Color.LightCoral;
            }
        }
        private async void txtIngMonto2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evita 'beep'
                btnConvertir2.PerformClick(); // ejecuta la conversión
            }
        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private async void btnConvertir2_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtIngMonto2.Text.Replace(".", ",");

                if (!decimal.TryParse(texto, out decimal montoCOP))
                {
                    lblResul2.Text = "Monto inválido.";
                    return;
                }

                var trmService = new TrmService();
                decimal trmActual = await trmService.GetTRMAsync();

                decimal resultadoUSD = montoCOP / trmActual;

                lblActu2.Text = $"TRM hoy: {trmActual:N2}\n\nÚltima conversión:\n\n{DateTime.Now:dd/MM/yyyy HH:mm:ss}";

                // 👉 FORMATO CON PUNTO DECIMAL
                lblResul2.Text = resultadoUSD.ToString("N4", CultureInfo.InvariantCulture);
            }
            catch
            {
                lblResul2.Text = "Error al obtener TRM";
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void lblActu2_Click(object sender, EventArgs e)
        {

        }

        private void lblResul2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblResul2.Text))
            {
                Clipboard.SetText(lblResul2.Text);
                Toast.Show("¡Copiado!", 700);  // << duración en milisegundos (rápido)
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
