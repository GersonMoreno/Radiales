using System;
using System.Collections.Generic;
using System.Text;

namespace ENTITY
{
    public class Activacion
    {
        public double Radial(double distancia)
        {
            return Math.Pow(distancia,2) * Math.Log(distancia);
        }
    }
}
