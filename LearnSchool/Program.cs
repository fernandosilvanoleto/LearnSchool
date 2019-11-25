using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnSchool.Entities;

namespace LearnSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Fernando Silva Noleto", 0.00);
            BusinessAccount bacc = new BusinessAccount(1002, "Leide", 0.00, 500.00);

            //Console.WriteLine(account.Balance);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Boob", 0.00, 200.00);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);
            Account acc40 = new SavingsAccount(1005, "Joaquim", 100.00, 10.00);


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
        }
    }
}
