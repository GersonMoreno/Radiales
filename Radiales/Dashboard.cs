using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using _BLL;
using _ENTITY;

namespace Radiales
{
    public partial class Dashboard : Form
    {
        Service Service;
        Red Red;

        public Dashboard()
        {
            Service = new Service();
            InitializeComponent();
            Red = Service.GetXML(null);
            Plataforma.Red = Red;
            //Service.Interpolar(Red);
            //Service.Entrenar(Red);
        }

        private void ShowInfo(Red N)
        {
            LbEntrada.Text = N.Patrones[0].Entradas.Count.ToString();
            LbPatrones.Text = N.Patrones.Count.ToString();
            LbSalidas.Text = N.Salidas.Count.ToString();
            TbError.Text = N.ErrorOptimo.ToString();
            NbRadiales.Value = N.Radiales.Count;
        }

        private void Abrir(Form ventana)
        {
            PnContenido.Controls.Clear();

            ventana.TopLevel = false;
            PnContenido.Controls.Add(ventana);
            PnContenido.Tag = true;
            ventana.Dock = DockStyle.Fill;
            ventana.Show();
        }


        private void Training(object sender, EventArgs e)
        {
            if (Red.Error <= Red.ErrorOptimo)
            {
                MessageBox.Show("Esta red ya se encuentra entrenada, proceda a simular");
                return;
            }
            if (Red.Patrones.Count <= 0)
            {
                MessageBox.Show("Esta red está vacia, llenela y entrenela");
                return;
            }
            /*else if (Red.Iteraciones <= 0)
            {
                MessageBox.Show("Por favor ingrese un número de iteraciones valido");
                return;
            }*/
            //CargarCapas();
            /*Red = Service.GetXML(null);
            Plataforma.Red = Red;*/
            BtnIniciar.Visible = false;
            //BtnPausa.Visible = true;
            RunTask();
            Abrir(new Graficador(Red));
        }

        private async void RunTask()
        {
            PbCarga.Visible = true;
            Plataforma.Continuar = true;
            Plataforma.Red = Red;
            var T = new Task(Service.Entrenar);
            T.Start();
            await T;
            Red = Plataforma.Red;
            ShowInfo(Red);
            PbCarga.Visible = false;
            //BtnPausa.Visible = false;
            BtnIniciar.Visible = true;
        }

        private void Simular(object sender, EventArgs e)
        {
            if (Red.Patrones.Count <= 0)
            {
                MessageBox.Show("Esta red está vacia, llenela y entrenela");
                return;
            }
            else if (Red.Error > Red.ErrorOptimo)
            {
                MessageBox.Show("La red aún no esta entrenada, por favor entrenela");
            }
            else
                Abrir(new Generalizador(Red, Service));
            //FrmSimulador = new Generalizador(Red, Service);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            var Result = OFD.ShowDialog();
            if (Result == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(OFD.FileName))
                    {
                        var Rd = Service.GetXML(OFD.FileName);
                        if (Rd != null)
                            Red = Plataforma.Red = Rd;
                        else
                            MessageBox.Show("El dataset está corrupto o está mal configurado");
                        ShowInfo(Red);
                    }
                    else
                        MessageBox.Show("Se ha eliminado o movido el archivo");
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error al abrir el archivo => " + er.Message, "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (Result == DialogResult.Cancel)
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SFD.FileName = $"data.XML";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                Service.PostXML(Red, SFD.FileName);
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
