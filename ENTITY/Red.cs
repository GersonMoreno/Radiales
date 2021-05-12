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
        public Activacion Activacion { get; set; }
        public Red()
        {
            Patrones = new List<Patron>();
            Radiales = new List<Radial>();
            Salidas = new List<Salida>();
            Activacion = new Activacion();
        }
        public double Entrenar()
        {
            
            for (int i = 0; i < Patrones.Count; i++)
            {
                for (int r = 0; r < Radiales.Count; r++)
                {
                    Radiales[r].Distancia = CalcularDistancia(Patrones[i].Entradas, Radiales[r].Valores);
                    Radiales[r].Activacion = Activacion.Radial(CalcularDistancia(Patrones[i].Entradas, Radiales[r].Valores));
                }
            }
            return 0.0;
        }
        private double CalcularDistancia(List<double> entradas, List<double> valorRadial)
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
