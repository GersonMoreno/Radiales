using System;
using System.Collections.Generic;
using System.Text;

namespace _ENTITY
{
    public class Activacion
    {
        public double Radial(double distancia)
        {
            distancia = Math.Abs(distancia);
            //var Result = distancia == 0 ? 0 : Math.Pow(distancia, 2) * Math.Log(distancia);
            var Result = Math.Pow(distancia, 2) * Math.Log(distancia);
            return Result;
        }
    }
}
