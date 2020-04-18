using System;
using System.Collections.Generic;
using System.Text;

namespace Cap10_Fixação.Entities
{
    abstract class Taxas
    {
        public string Name { get; set; }
        public double RendaAnual { get; set; }

        public Taxas() { }

        public Taxas(string name, double rendaAnual)
        {
            Name = name;
            RendaAnual = rendaAnual;

        }

        public abstract double Taxa();



    }
}
