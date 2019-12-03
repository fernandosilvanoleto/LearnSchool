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

            Console.WriteLine("Room Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Check-out date (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if(checkout <= checkin)
            {
                Console.WriteLine("Data Check-In menor que Check-Out!!! Inválidos os dados inseridos!!!");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();

                Console.WriteLine("Enter data to update the reservation: ");

                Console.WriteLine("Room Number: ");
                number = int.Parse(Console.ReadLine());

                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                if (checkin < now || checkout < now)
                {
                    Console.WriteLine("Erro na hora de reservar!!! As datas devem ser futuras!!! Verifique novamente!!!");
                }
                else if (checkout <= checkin)
                {
                    Console.WriteLine("Data Check-In menor que Check-Out!!! Inválidos os dados inseridos!!!");
                }
                else
                {
                    reservation.UpdateDates(checkin, checkout);
                    Console.WriteLine("New Reservation: " + reservation);
                }
            }

        }
    }
}
