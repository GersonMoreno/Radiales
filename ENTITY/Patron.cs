using System;
using System.Collections.Generic;
namespace ENTITY
{
    public class Patron
    {
        public List<double> Entradas { get; set; }
        public List<double> Esperado { get; set; }

        public Patron()
        {
            Entradas = new List<double>();
            Esperado = new List<double>();
        }

        public Patron(List<double> Entradas)
        {
            this.Entradas = Entradas;
            Esperado = new List<double>();
        }

    }
}
