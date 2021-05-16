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

        public void Entrenar()
        {
            Plataforma.Red.Radiales.ForEach(r =>
            {
                r.CalcularValores(Plataforma.Red.Patrones);
            });
            List<double> Activaciones = new List<double>();
            List<double> Pesos = new List<double>();
            double ErrorPatron = 0.0, EG = 0.0;
            
            for (int i = 0; i < Plataforma.Red.Patrones.Count; i++)
            {
                for (int r = 0; r < Plataforma.Red.Radiales.Count; r++)
                {
                    Plataforma.Red.Radiales[r].Distancia.Add(Plataforma.Red.CalcularDistancia(Plataforma.Red.Patrones[i].Entradas, Plataforma.Red.Radiales[r].Valores));
                    Plataforma.Red.Radiales[r].Activacion.Add(Activacion.Radial(Plataforma.Red.CalcularDistancia(Plataforma.Red.Patrones[i].Entradas, Plataforma.Red.Radiales[r].Valores)));
                }   
            }
            Plataforma.Red = Repo.Interpolar(Plataforma.Red);
            for (int j = 0; j < Plataforma.Red.Salidas.Count; j++)
            {
                for (int i = 0; i < Plataforma.Red.Patrones.Count; i++)
                {
                    Activaciones = new List<double>();
                    Pesos = new List<double>();
                    ErrorPatron = 0.0;
                    for (int h = 0; h < Plataforma.Red.Radiales.Count; h++)
                    {
                        Activaciones.Add(Plataforma.Red.Radiales[h].Activacion[i]);
                        Pesos.Add(Plataforma.Red.Salidas[j].Pesos[h].Valor);
                    }
                    
                    Plataforma.Red.Salidas[j].YR = CalcularYR(Activaciones, Pesos,Plataforma.Red.Salidas[j].Umbral.Valor);
                    Plataforma.Red.Salidas[j].Error = Plataforma.Red.Salidas[j].YD - Plataforma.Red.Salidas[j].YR;
                    ErrorPatron += Math.Abs(Plataforma.Red.Salidas[j].Error);
                }
                ErrorPatron /= Plataforma.Red.Patrones.Count;
                EG += ErrorPatron;
            }
            EG /= Plataforma.Red.Salidas.Count;
            if (EG> Plataforma.Red.ErrorOptimo)
            {
                var numeroRadios = Math.Round(Plataforma.Red.Radiales.Count*1.5);
                Plataforma.Red.Radiales.Clear();
                for (int i = 0; i < numeroRadios; i++)
                {
                    Plataforma.Red.Radiales.Add(new Radial());
                }
                Console.WriteLine("\n" + EG);
                Plataforma.Red.Error = EG;
                Entrenar();                
            }
            else
            {
                Console.WriteLine("Criterio de paro");
                Plataforma.Red.Error = EG;
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

        public Red GetXML(string Path)
        {
            return Repo.GetXML(Path);
        }

        public List<Patron> GetDS(string Path)
        {
            return Repo.GetDS(Path);
        }

        public void PostXML(Red R, string Path)
        {
            Repo.PostXML(R, Path);
        }

    }
}
