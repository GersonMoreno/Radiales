using System;
using System.Collections.Generic;
using System.Text;

namespace ENTITY
{
    public class Radial
    {
        public List<double> Valores { get; set; }
        public double Distancia { get; set; }
        public double Activacion { get; set; }
        public List<Peso> Pesos { get; set; }
        public Umbral Umbral { get; set; }
        public Radial()
        {
            Valores = new List<double>();
            Pesos = new List<Peso>();
            Umbral = new Umbral();
        }
        
    }
}
