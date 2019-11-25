using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSchool.Entities
{
    class BusinessAccount : Account //Herança em C# é assim
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanlimit)
            : base(number, holder, balance) // PEGANDO ATRIBUTO DA CLASSE PAI == USO DO "BASE"
        {
            LoanLimit = loanlimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

        public override void Withdraw(double amount)
        {
            // importante que o método da classe pai esteja com o nome "virtual" no { public virtual void WITHDRAW () {} }
            Balance -= amount;
        }

    }
}
