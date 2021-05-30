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
            if (Plataforma.Continuar)
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
                var ErrorIteracion = .0;
                for (int i = 0; i < Plataforma.Red.Patrones.Count; i++)
                {
                    ErrorPatron = 0.0;
                    for (int j = 0; j < Plataforma.Red.Salidas.Count; j++)
                    {
                        Activaciones = new List<double>();
                        Pesos = new List<double>();
                        for (int h = 0; h < Plataforma.Red.Radiales.Count; h++)
                        {
                            Activaciones.Add(Plataforma.Red.Radiales[h].Activacion[i]);
                            Pesos.Add(Plataforma.Red.Salidas[j].Pesos[h].Valor);
                        }
                        Plataforma.Red.Salidas[j].YR = Plataforma.Red.CalcularYR(Activaciones, Pesos, Plataforma.Red.Salidas[j].Umbral.Valor);
                        Plataforma.Red.Salidas[j].Error = Plataforma.Red.Salidas[j].YD - Plataforma.Red.Salidas[j].YR;
                        ErrorPatron += Math.Abs(Plataforma.Red.Salidas[j].Error);
                    }
                    ErrorIteracion += ErrorPatron / Plataforma.Red.Salidas.Count;
                }
                EG = ErrorPatron / Plataforma.Red.Patrones.Count;
                //if (EG > 0.0001 && EG < 0.001)
                //if (EG < Plataforma.Red.ErrorOptimo && (EG > .0001 && EG < .005))
                if (EG < Plataforma.Red.ErrorOptimo)
                {
                    Console.WriteLine("Criterio de paro");
                    Plataforma.Red.Error = EG;
                    PostXML(Plataforma.Red, null);
                    Console.WriteLine(EG);
                }
                //else if (EG > Plataforma.Red.ErrorOptimo)
                else
                {
                    var numeroRadios = Plataforma.Red.Radiales.Count + 1;
                    /*Plataforma.Red.Radiales.Clear();
                    for (int i = 0; i < numeroRadios; i++)
                    {
                        Plataforma.Red.Radiales.Add(new Radial());
                    }*/
                    Console.WriteLine("Overfitting o error goal no superado");
                    Console.WriteLine($"Nuevos radios: {numeroRadios} - error anterior: {EG}");
                    Plataforma.Red.Error = EG;
                    Plataforma.Red.Iteraciones++;
                    PostXML(Plataforma.Red, null);
                    Plataforma.Red.Radiales.ForEach(r =>
                    {
                        r.Activacion.Clear();
                        r.Distancia.Clear();
                    });
                    Entrenar();
                }
            }           
            
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
