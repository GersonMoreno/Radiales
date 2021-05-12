using System;
using System.Collections.Generic;
using System.Text;

namespace ENTITY
{
    public class Salida
    {
        public double Valor { get; set; }
        public List<Peso> Pesos { get; set; }
        public  Umbral  Umbral { get; set; }
        public double Error { get; set; }
        public double YD { get; set; }
        public double YR { get; set; }

        public Salida()
        {
            Pesos = new List<Peso>();
            Umbral = new Umbral();
        }
    }
}
