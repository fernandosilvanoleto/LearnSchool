using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnSchool.Entities;
using LearnSchool.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;

namespace LearnSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * PRIMEIRA PARTE - 01
             * 
             * 
             */

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Format Error: " + fe.Message);
            }
            finally {
                Console.WriteLine("Testando Finally!!!");
            } // é um bloco que contém código a ser executado independentemente de ter ocorrido ou não uma exceção!!!
           
        }
    }
}
