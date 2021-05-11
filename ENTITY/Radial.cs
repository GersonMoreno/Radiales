using System;
using System.Collections.Generic;
using System.Text;

namespace ENTITY
{
    public class Radial
    {
        public List<double> Valores { get; set; }
        public List<double> Distancias { get; set; }
        public Radial()
        {
            Distancias = new List<double>();
            Valores = new List<double>();
        }
        
    }
}
