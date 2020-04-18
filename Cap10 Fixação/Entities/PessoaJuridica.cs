using System;
using System.Collections.Generic;
using System.Text;

namespace Cap10_Fixação.Entities
{
    class PessoaJuridica : Taxas
    {
        public int NumeroColaborades { get; set; }

        public PessoaJuridica() { }

        public PessoaJuridica(string name, double rendaAnual, int numeroColaborades) : base(name, rendaAnual)
        {

            NumeroColaborades = numeroColaborades;


        }

        public override double Taxa()
        {
            double imp = 0.0;

            if (NumeroColaborades > 10)
            {

                imp = RendaAnual * 0.14;

            }

            else
            {
                imp = RendaAnual * 0.16;
            }

            return imp;
        }
    }
}
