using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _ENTITY;

namespace Radiales
{
    public partial class Home : Form
    {
        public Home(Red Red)
        {
            InitializeComponent();
            ShowInfo(Red);
        }

        private void ShowInfo(Red Red)
        {
            LbPath.Text = "/DS.XML";
            LbPatrones.Text = Red.Patrones.Count.ToString();
            LbPesos.Text = Red.Salidas.Count.ToString();
            LbError.Text = Red.Error.ToString();
            LbIteraciones.Text = Red.Iteraciones.ToString();
            LbErrorMax.Text = Red.ErrorOptimo.ToString();
            LbUmbral.Text = Red.Salidas.Count.ToString();
        }
    }
}
