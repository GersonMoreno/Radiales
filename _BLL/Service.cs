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
        public Service()
        {
            Repo = new Repository();
            Activacion = new Activacion();
        }

        public void Interpolar(Red Red)
        {
            Repo.Interpolar(Red);
        }
        public void Entrenar(Red Red)
        {
            Red.Radiales.ForEach(r =>
            {
                r.CalcularValores(Red.Patrones);
            });
            List<double> Activaciones = new List<double>();
            List<double> Pesos = new List<double>();
            double ErrorPatron = 0.0, EG = 0.0;
            
            for (int i = 0; i < Red.Patrones.Count; i++)
            {
                for (int r = 0; r < Red.Radiales.Count; r++)
                {
                    Red.Radiales[r].Distancia.Add(Red.CalcularDistancia(Red.Patrones[i].Entradas, Red.Radiales[r].Valores));
                    Red.Radiales[r].Activacion.Add(Activacion.Radial(Red.CalcularDistancia(Red.Patrones[i].Entradas, Red.Radiales[r].Valores)));
                }   
            }
            Red = Repo.Interpolar(Red);
            for (int j = 0; j < Red.Salidas.Count; j++)
            {
                for (int i = 0; i < Red.Patrones.Count; i++)
                {
                    Activaciones = new List<double>();
                    Pesos = new List<double>();
                    ErrorPatron = 0.0;
                    for (int h = 0; h < Red.Radiales.Count; h++)
                    {
                        Activaciones.Add(Red.Radiales[h].Activacion[i]);
                        Pesos.Add(Red.Salidas[j].Pesos[h].Valor);
                    }
                    
                    Red.Salidas[j].YR = CalcularYR(Activaciones, Pesos,Red.Salidas[j].Umbral.Valor);
                    Red.Salidas[j].Error = Red.Salidas[j].YD - Red.Salidas[j].YR;
                    ErrorPatron += Math.Abs(Red.Salidas[j].Error);
                }
                ErrorPatron /= Red.Patrones.Count;
                EG += ErrorPatron;
            }
            EG /= Red.Salidas.Count;
            if (EG> Red.ErrorOptimo)
            {
                var numeroRadios = Math.Round(Red.Radiales.Count*1.5);
                Red.Radiales.Clear();
                for (int i = 0; i < numeroRadios; i++)
                {
                    Red.Radiales.Add(new Radial());
                }
                Console.WriteLine("\n" + EG);
                Entrenar(Red);
                
            }
            else
            {
                Console.WriteLine("Criterio de paro");
                Console.WriteLine(EG);
            }
            
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
        public Red GetXML()
        {
            return Repo.GetXML(null);
        }
        
    }
}
