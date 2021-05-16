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

using _ENTITY;
using _BLL;

namespace Radiales
{
    public partial class Generalizador : Form
    {
        private readonly Red Red;

        private readonly Service Service;

        public Generalizador(Red Red, Service Service)
        {
            this.Service = Service;
            this.Red = Red;
            InitializeComponent();
        }
        private void CrearColumnas(List<Patron> Patrones)
        {
            var i = 1;
            dataGridView1.Columns.Clear();
            if (Patrones.Count > 0)
            {
                foreach (var item in Red.Patrones[0].Entradas)
                {
                    var Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    Columna.HeaderText = "E" + i;
                    Columna.Name = Columna.HeaderText;
                    dataGridView1.Columns.Add(Columna);
                    i++;
                }
                for (int s = 0; s < Red.Salidas.Count; s++)
                {
                    var _Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    _Columna.HeaderText = "YR" + (s + 1);
                    _Columna.Name = _Columna.HeaderText;
                    dataGridView1.Columns.Add(_Columna);
                }
            }
        }

        private bool ValidarDS(List<Patron> Patrones, Red Red)
        {
            if (Red.Patrones.Count <= 0 || Patrones.Count <= 0)
                return true;
            else if (Patrones[0].Entradas.Count == Red.Patrones[0].Entradas.Count)
                return false;
            else
                return true;
        }

        private void Start(object sender, EventArgs e)
        {
            ShowInfo(Red);
            var Result = OFD.ShowDialog();
            if (Result == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(OFD.FileName))
                    {
                        var Ps = Service.GetDS(OFD.FileName);
                        if (Ps != null)
                        {
                            if (ValidarDS(Ps, Red))
                            {
                                MessageBox.Show("El dataset no cuenta con las caracteristicas de la red entrenada");
                                return;
                            }
                            LbPath.Text = OFD.FileName;
                            LbPatrones.Text = "" + Ps.Count();
                            CrearColumnas(Ps);
                            var Row = new List<string>();
                            foreach (var item in Ps)
                            {
                                Row.Clear();
                                foreach (var it2 in item.Entradas)
                                {
                                    Row.Add(it2.ToString());
                                }
                                var Yrs = Red.Generalizar(item);
                                Yrs.ForEach(x =>
                                {
                                    Row.Add(x.ToString());
                                });
                                dataGridView1.Rows.Add(Row.ToArray());
                            }
                        }
                        else
                            MessageBox.Show("El dataset está corrupto o está mal configurado");
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

        private void ShowInfo(Red Red)
        {
            Plataforma.Red = Red;
            LbError.Text = "" + Plataforma.Red.Error;
            LbIteraciones.Text = "" + Plataforma.Red.Entrenamientos;
            //LbPesos.Text = "" + Plataforma.W;
            //LbUmbral.Text = "" + Plataforma.Red.Umbral.Valor;
        }

    }
}
