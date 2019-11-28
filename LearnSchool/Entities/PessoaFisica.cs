using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSchool.Entities
{
    class PessoaFisica : Pessoa
    {

        public double GastoSaude { get; set; }

        public  PessoaFisica(string nome, double rendaanual, double gastosaude)
            : base(nome, rendaanual)
        {
            GastoSaude = gastosaude;
        }

        public override double CalculoImposto()
        {
            double RendaLiquida = 0.00; // tenho que iniciar com valor zero
            if(GastoSaude > 20000)
            {
                if (GastoSaude > 0)
                {
                   RendaLiquida = (RendaAnual * 0.15) - (GastoSaude * 0.5);
                }
                else
                {
                   RendaLiquida = RendaAnual * 0.15;
                }               
            }
            else
            {
                if (GastoSaude > 0)
                {
                    RendaLiquida = (RendaAnual * 0.25) - (GastoSaude * 0.5);
                }
                else
                {
                    RendaLiquida = RendaAnual * 0.25;
                }
            }
            return RendaLiquida;
        }
    }
}
