using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _BLL;
using _ENTITY;

namespace Radiales
{
    public partial class Dashboard : Form
    {
        Service Service;
        public Dashboard()
        {
            Service = new Service();
            InitializeComponent();
            Service.Interpolar();
        }
    }
}
