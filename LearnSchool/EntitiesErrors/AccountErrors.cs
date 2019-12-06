using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSchool.EntitiesErrors
{
    class AccountErrors
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public AccountErrors() { }

        public AccountErrors(int number, string holder, double balance, double withdramlimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withdramlimit;
        }

        public void Deposit(double amount)
        {
            
        }

        public void WithDraw(double amount)
        {

        }

    }
}
