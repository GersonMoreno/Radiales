using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;

using _ENTITY;

namespace Radiales
{
    public partial class Graficador : Form
    {
        private int i { get; set; }
        public bool Crear { get; set; }
        public double Menor { get; set; }

        private readonly Red Red;

        public Graficador(Red Red)
        {
            Menor = 100;
            this.Red = Red;
            Crear = true;
            InitializeComponent();
            Config();
            Config(Red);
        }

        private void Config(Red Red)
        {
            chart2.Series.Clear();
            grafica1.Series.Clear();
            grafica1.Series.Add("ErrorIT");
            grafica1.Series["ErrorIT"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            var i = 1;
            foreach (var item in Red.Salidas)
            {
                chart2.Series.Add("Error " + i);
                chart2.Series["Error " + i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                i++;
            }
        }

        private void Config()
        {
            var watcher = new FileSystemWatcher(@".\");

            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Changed += OnChanged;
            watcher.Filter = "*.XML";
            watcher.IncludeSubdirectories = false;
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    Menor = Menor > Plataforma.Red.Error ? Plataforma.Red.Error : Menor;
                    grafica1.Series["ErrorIT"].Points.Add(Plataforma.Red.Error);
                    var j = 1;
                    foreach (var item in Plataforma.Red.Salidas)
                    {
                        chart2.Series["Error " + j].Points.Add(item.Error);
                        j++;
                    }
                    i++;
                    CargarDatos();
                }));
            }
        }

        public void CargarDatos()
        {
            //LbUmbral.Text = Plataforma.Red.Umbral.Valor.ToString();
            LbError.Text = Plataforma.Red.Error.ToString();
            LbMenor.Text = Menor.ToString();
            LbIntentos.Text = Plataforma.Red.Iteraciones.ToString();
            LbErrorPor.Text = (Plataforma.Red.Error / Plataforma.Red.ErrorOptimo).ToString();
            //LbWs.Text = Plataforma.W;
        }

    }
}
