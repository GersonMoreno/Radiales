using System;
using System.Collections.Generic;
using System.Text;

namespace ENTITY
{
    public class Capa
    {
        public List<Radial> Radiales { get; set; }
        public Capa()
        {
            Radiales = new List<Radial>();
        }
    }
}
