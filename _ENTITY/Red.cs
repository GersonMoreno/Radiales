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

        public List<double> Generalizar(Patron patron)
        {

            List<double> Pesos;
            List<double> YRs = new List<double>();
            List<double> activaciones = new List<double>();
            for (int r = 0; r < Radiales.Count; r++)
            {
                activaciones.Add(Activacion.Radial(CalcularDistancia(patron.Entradas, Radiales[r].Valores)));
            }
            for (int j = 0; j < Salidas.Count; j++)
            {
                Pesos = new List<double>();
                for (int i = 0; i < activaciones.Count; i++)
                {
                    for (int h = 0; h < Radiales.Count; h++)
                    {
                        Pesos.Add(Salidas[j].Pesos[h].Valor);
                    }
                    YRs.Add(CalcularYR(activaciones, Pesos, Salidas[j].Umbral.Valor));
                }

            }
            return YRs;
        }

        public double CalcularYR(List<double> Activaciones, List<double> Pesos, double Umbral)
        {
            double suma = 0.0, Xo = 1.0;
            for (int i = 0; i < Activaciones.Count; i++)
            {
                suma += Activaciones[i] * Pesos[i];
            }
            return (Xo * Umbral) + suma;
        }

    }
}
