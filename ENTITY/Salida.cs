using System;
using System.Collections.Generic;
using System.Text;

namespace ENTITY
{
    public class Salida
    {
        public List<double> Valores { get; set; }
        public List<Peso> Pesos { get; set; }
        public  Umbral  Umbral { get; set; }
        public Salida()
        {
            Pesos = new List<Peso>();
            Valores = new List<double>();
            Umbral = new Umbral();
        }
    }
}
