using System;
using _DAL;
using _ENTITY;
using System.Collections.Generic;

namespace _BLL
{
    public class Service
    {
        Repository Repo;
        public Activacion Activacion { get; set; }
        public Red Red { get; set; }
        public Service()
        {
            Repo = new Repository();
            Red = new Red();
            Activacion = new Activacion();
        }

        public void Interpolar(Red Red)
        {
            Repo.Interpolar(Red);
        }
        public void Entrenar()
        {
            List<double> salidas = new List<double>();
            double ErrorPatron = 0.0,EG=0.0;
            
            for (int i = 0; i < Red.Patrones.Count; i++)
            {
                for (int r = 0; r < Red.Radiales.Count; r++)
                {
                    Red.Radiales[r].Distancia = Red.CalcularDistancia(Red.Patrones[i].Entradas, Red.Radiales[r].Valores);
                    Red.Radiales[r].Activacion = Activacion.Radial(Red.Radiales[r].Distancia);

                    Red = Repo.Interpolar(Red);
                }
                
            }
        }
        public double CalcularYR(List<double> salida, List<Peso> Pesos, double Umbral)
        {
            return 0.0;
        }
        public Red GetXML()
        {
            return Repo.GetXML(null);
        }

    }
}
