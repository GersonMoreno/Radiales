using System;
using System.Collections.Generic;
using System.Text;

namespace _ENTITY
{
    public class Radial
    {
        public List<double> Valores { get; set; }
        public List<double> Distancia { get; set; }
        public List<double> Activacion { get; set; }
        
        public Radial()
        {
            Valores = new List<double>();
            Distancia = new List<double>();
            Activacion = new List<double>();
        }
        
    }
}
