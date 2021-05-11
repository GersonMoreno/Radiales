using System;
using System.Collections.Generic;
using System.Text;

namespace ENTITY
{
    public class Red
    {
        public  List<Patron> Patrones { get; set; }
        public List<Radial> Radiales { get; set; }
        public List<Salida> Salidas { get; set; }
        public Red()
        {
            Patrones = new List<Patron>();
            Radiales = new List<Radial>();
            Salidas = new List<Salida>();
        }
        public double Entrenar()
        {
            for (int i = 0; i < Patrones.Count; i++)
            {

            }
            return 0.0;
        }
    }
}
