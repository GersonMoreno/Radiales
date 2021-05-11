using System;
using System.Collections.Generic;
namespace ENTITY
{
    public class Patron
    {
        public List<double> Entradas { get; set; }
        public Patron()
        {
            Entradas = new List<double>();
        }
    }
}
