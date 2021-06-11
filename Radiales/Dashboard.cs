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
using System.Diagnostics;

using _BLL;
using _ENTITY;

namespace Radiales
{
    public partial class Radiales : Form
    {
        Service Service;
        Red Red;

        public Radiales()
        {
            Service = new Service();
            InitializeComponent();
            BtnPausa.Visible = false;
            BtnIniciar.Visible = true;
            Config();
        }
        private void Config()
        {
            //FILTROS
            OFD.Filter = "Archivo XML (*.XML)|*.XML";
            SFD.Filter = "Archivo XML (*.XML)|*.XML";

            //CONFIG LINK
            //linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://github.com/bdmtnz");
            //linkLabel2.Links.Add(0, linkLabel2.Text.Length, "https://sites.google.com/a/unicesar.edu.co/tonnyjimenezm/");

            //CARGA DE CACHÉ
            var Rd = Service.GetXML(null);
            if (Rd != null)
                Red = Plataforma.Red = Rd;
            else
                MessageBox.Show("El dataset está corrupto o está mal configurado");
            ShowInfo(Red);
            Abrir(new Home(Red));
        }


        private void ShowInfo(Red N)
        {
            LbEntrada.Text = N.Patrones[0].Entradas.Count.ToString();
            LbPatrones.Text = N.Patrones.Count.ToString();
            LbSalidas.Text = N.Salidas.Count.ToString();
            NbError.Value = (decimal)N.ErrorOptimo;
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
            BtnPausa.Visible = true;
            RunTask();
            Abrir(new Graficador(Red));
        }

        private async void RunTask()
        {
            //PbCarga.Visible = true;
            Plataforma.Continuar = true;
            Plataforma.Red = Red;
            var T = new Task(Service.Entrenar);
            T.Start();
            await T;
            Red = Plataforma.Red;
            ShowInfo(Red);
            //PbCarga.Visible = false;
            BtnPausa.Visible = false;
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
                        Abrir(new Home(Red));
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

        private void OpenLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo PInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(PInfo);

        }

        private void BtnPausa_Click(object sender, EventArgs e)
        {
            BtnPausa.Visible = false;
            BtnIniciar.Visible = true;
            Red = Plataforma.Red;
            Plataforma.Continuar = false;
            ShowInfo(Red);
        }

        private void GlChange(object sender, EventArgs e)
        {
            Red.ErrorOptimo = (double)NbError.Value;
        }

        private void RdChange(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            Red.Radiales.Clear();
            Red.Error = 10;
            Red.ErrorOptimo = (double)NbError.Value;
            for (int i = 0; i < NbRadiales.Value; i++)
            {
                Red.Radiales.Add(new Radial());
            }
            foreach (var item in Red.Salidas)
            {
                item.Pesos.Clear();
                for (int i = 0; i < NbRadiales.Value; i++)
                {
                    item.Pesos.Add(new Peso());
                }
            }
            Plataforma.Red = Red;
        }
    }
}
