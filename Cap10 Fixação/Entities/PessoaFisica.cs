using System;
using System.Collections.Generic;
using System.Text;

namespace Cap10_Fixação.Entities
{
    class PessoaFisica : Taxas
    {
        public double GastosComSaude { get; set; }

        public PessoaFisica() { }

        public PessoaFisica(double gastosComSaude, string name, double rendaAnual) : base(name, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

                       

        public override double Taxa()
        {
            double imp = 0.0;

            if (RendaAnual < 20000)
            {
                imp = (RendaAnual * 0.15) - (GastosComSaude * 0.50);

            }
            else if (RendaAnual >= 20000)
            {
                imp = (RendaAnual * 0.25) - (GastosComSaude * 0.50);

            }

            return imp; 
        }
    }
}
