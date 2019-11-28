using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSchool.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaanual, int numerofuncionarios) 
            : base(nome, rendaanual)
        {
            NumeroFuncionarios = numerofuncionarios;
        }

        public override double CalculoImposto()
        {
            double RendaLiquida = 0.00; // tenho que iniciar com valor zero
            
            if(NumeroFuncionarios < 10)
            {
                RendaLiquida = RendaAnual * 0.16;
            }
            else
            {
                RendaLiquida = RendaAnual * 0.14;
            }

            return RendaLiquida;
        }
    }
}
