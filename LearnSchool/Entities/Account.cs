using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSchool.Entities
{
    class Account
    {

        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            // precisa do nome "virtual" PARA SOBRESCREVER EM MÉTODOS FILHOS !!!
            Balance -= amount + 5.00;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
