using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSchool.Entities
{    
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        // sealed -> sela a classe para não ter mais subclasse (evita que a classe seja herdada!!!) -= pode ser usado para métodos

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance) // PEGANDO ATRIBUTO DA CLASSE PAI == USO DO "BASE"
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public void Deposito(double amount)
        {
            Balance += amount;
        }

      public override void Withdraw(double amount)
        {
            // importante que o método da classe pai esteja com o nome "virtual" no { public virtual void WITHDRAW () {} }
            base.Withdraw(amount);
            Balance -= 2.00;
        }

    }
}
