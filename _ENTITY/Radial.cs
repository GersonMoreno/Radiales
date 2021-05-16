using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _ENTITY
{
    public class Radial
    {
        public List<double> Valores { get; set; }
        public List<double> Distancia { get; set; }
        public List<double> Activacion { get; set; }
        
        public Radial()
        {
            Valores = new List<double>();
            Distancia = new List<double>();
            Activacion = new List<double>();
        }

        public void CalcularValores(List<Patron> Patrones)
        {
            //OBTENEMOS MAYOR Y MENOR
            var Entradas = new List<double>();
            Patrones.ForEach(p =>
            {
                p.Entradas.ForEach(e =>
                {
                    Entradas.Add(e);
                });
            });
            Entradas = Entradas.OrderBy(x => x).ToList();
            //DEFINIMOS EL RANGO
            var Min = Entradas[0];
            var Max = Entradas[Entradas.Count - 1];
            for (int i = 0; i < Patrones[0].Entradas.Count; i++)
            {
                Valores.Add(Random(Min, Max));
            }
        }

        private double Random(double Menor, double Mayor)
        {
            var R = new Random();
            //var Negativo = Convert.ToBoolean(Math.Round(R.NextDouble()));
            var Negativo = Menor < 0 || Mayor < 0;
            var Numero = 0.0;
            var Result = 0.0;
            do
            {
                Numero = R.NextDouble() * Mayor;
                System.Threading.Thread.Sleep(100);
                Result = Negativo ? Numero * -1 : Numero;
            }
            while (Result < Menor);
            Console.WriteLine($"Menor: {Menor} | Mayor: {Mayor} | Resultado: {Result}");
            return Result;
        }

    }
}
