using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnSchool.Entities;
using LearnSchool.Entities.Enums;
using LearnSchool.EntitiesErrors;
using System.Collections.Generic;
using System.Globalization;
using LearnSchool.EntitiesErrors.Exceptions;

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
             */

            /*
             * SEGUNDA PARTE - 02 - TRATAMENTO DE EXCEÇÕES RUINS!!!
             *             
             */

            try
            {

                Console.WriteLine("Room Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkin, checkout);

                Console.WriteLine();
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();

                Console.WriteLine("Enter data to update the reservation: ");

                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);

                Console.WriteLine();
                Console.WriteLine("Reservation New Update: " + reservation);
                Console.WriteLine();

            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in Reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e) //é o mais genérico
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }                        

        }
    }
}
