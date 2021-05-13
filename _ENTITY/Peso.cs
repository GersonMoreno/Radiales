using System;
using System.Collections.Generic;
using System.Text;

namespace _ENTITY
{
    public class Peso
    {
        public double Valor { get; set; }

        public Peso()
        {
            Valor = new double();
        }

        public Peso(double Valor)
        {
            this.Valor = Valor;
        }

    }
}
