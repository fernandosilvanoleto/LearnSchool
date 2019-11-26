using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnSchool.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace LearnSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * PRIMEIRA PARTE 01
             * 
            Account account = new Account(1001, "Fernando Silva Noleto", 1000);
            BusinessAccount bacc = new BusinessAccount(1002, "Leide", 0.00, 500.00);

            //Console.WriteLine(account.Balance);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Boob", 1000, 200);
            Account acc3 = new SavingsAccount(1004, "Anna", 1000, 1000);
            Account fer = new Account(10, "Boloteca", 1000);

            fer.Withdraw(10.00);
            acc2.Withdraw(10.00);
            acc3.Withdraw(10.00);
            Console.WriteLine("Nome do Cliente: " + fer.Holder + " Conta account: " + fer.Balance);
            Console.WriteLine("Nome do Cliente: " + acc2.Holder + " Conta acc2: " + acc2.Balance);
            Console.WriteLine("Nome do Cliente: " + acc3.Holder + " Conta acc3: " + acc3.Balance);

            //DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3;

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.00);
                Console.WriteLine("Loan!!!");
            }
            else if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!!!");
            }
            */

            /*
             * SEGUNDA PARTE 02            
             *              
             */

            List<Employee> listaFuncionario = new List<Employee>();

            Console.WriteLine("Quantidade de funcionários para serem cadastrados: ");
            int quantidadeFuncionario = int.Parse(Console.ReadLine());

            for(int i = 1; i <= quantidadeFuncionario; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");

                Console.Write("OutSourced (y/n)? ");
                char Terceirizado = char.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.WriteLine("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // CultureInfo.InvariantCulture é usado para especificar que o usuário deve inserir pontos e não vírgulas em double

                if(Terceirizado == 'y')
                {
                    Console.WriteLine("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listaFuncionario.Add(new OutSourcedEmployee(name, hours, valueperhour, additionalCharge));

                    Console.WriteLine("Funcionário Terceirizado cadastrado com sucesso!!!");

                }
                else
                {
                    listaFuncionario.Add(new Employee(name, hours, valueperhour));

                    Console.WriteLine("Funcionário Padrão cadastrado com sucesso!!!");

                }                
            }

            Console.WriteLine();
            Console.WriteLine("PAYAMENTS");

            foreach (Employee funcionario in listaFuncionario)
            {
                Console.WriteLine("Nome do Funcionario: " + funcionario.Name + " - $ " 
                    + funcionario.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
            

        }
    }
}
