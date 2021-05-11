using System;
using System.Collections.Generic;
using System.Text;

namespace ENTITY
{
    public class Radial
    {
        public List<double> Valores { get; set; }
        public List<Distancia> Distancias { get; set; }
        public Radial()
        {
            Distancias = new List<Distancia>();
            Valores = new List<double>();
        }
        
    }
}
