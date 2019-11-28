using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSchool.Entities
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

       // public Pessoa() { }

        public Pessoa(string nome, double rendaanual)
        {
            Nome = nome;
            RendaAnual = rendaanual;
        }

        public abstract double CalculoImposto();

    }
}
