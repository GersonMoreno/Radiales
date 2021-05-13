using System;
using System.Collections.Generic;
using System.Text;

namespace _ENTITY
{
    public class Red
    {
        public  List<Patron> Patrones { get; set; }
        public List<Radial> Radiales { get; set; }
        public List<Salida> Salidas { get; set; }
        public Activacion Activacion { get; set; }
        public int Iteraciones { get; set; }
        public int Entrenamientos { get; set; }
        public double Error { get; set; }
        public double ErrorOptimo { get; set; }

        public Red()
        {
            Patrones = new List<Patron>();
            Radiales = new List<Radial>();
            Salidas = new List<Salida>();
            Activacion = new Activacion();
        }
        public void Entrenar()
        {

            

        }
        public double CalcularDistancia(List<double> entradas, List<double> valorRadial)
        {
            double sumatoria=0.0;
            for (int i = 0; i < entradas.Count; i++)
            {
                sumatoria += Math.Pow((entradas[i] - valorRadial[i]),2);
            }
            return Math.Sqrt(sumatoria);
        }
    }
}
