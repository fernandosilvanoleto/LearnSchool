using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnSchool.Entities.Enums;

namespace LearnSchool.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        //public Shape() { }

        public Shape(Color color)
        {
            Color = Color;
        }

        public abstract double Area(); // para um método ser abstrato, a classe dela deve ser abstrata também. Caso essa classe seja pai de outra classe, a classe filha deve implementar o método abstrato, sem reclamar kkkkkkkkk. Fica a Dica!!!

    }
}
