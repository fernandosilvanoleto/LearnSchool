using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnSchool.EntitiesErrors.Exceptions;

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
            if(balance <= 0.00 || withdramlimit <= 0.00)
            {
                throw new DomainException("Withdraw Error! Por favor, deposita valor maior que R$0.00 ou Valor Limite de Conta maior que R$ 0.00!!! Boloteca Investimento S/A agradeçe!!!");
            }
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withdramlimit;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0.00)
            {
                throw new DomainException("Withdraw Error! Valor para depositar tem que ser maior que 0.00");
            }
            else
            {
                Balance += amount;
            }
        }

        public void WithDraw(double amount)
        {            
            if(amount > WithDrawLimit)
            {
                throw new DomainException("Withdraw Error! Por favor, saque um valor menor que o limite permitido. Valor limite de saque permitido para sua conta é: " + WithDrawLimit);
            }
            else
            {
                if(Balance == 0.00)
                {
                    throw new DomainException("Withdraw Error! A sua conta está com R$ 0,00 na conta! Por favor, vá em uma Agência por perto e deposita seu dinheiro!");
                }
                else if(amount > Balance)
                {
                    throw new DomainException("Withdraw Error! Saldo Insuficiente!!!");
                }
                else
                {
                    Balance -= amount;
                }
            }
        }

        public string NewBalance()
        {
            return "New Balance: " + Balance;
        }

        public override string ToString()
        {
            return "Number "
                    + Number
                    + ", Holder: "
                    + Holder
                    + ", Balance: "
                    + Balance
                    + "WithDrawLimit: "
                    + WithDrawLimit
                    + " : Boloteca Investimentos S/A!!!";
        }
    }
}
