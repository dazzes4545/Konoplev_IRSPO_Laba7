using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    internal class BankAccount
    {
        public string AccountNumber;
        private decimal balance;

        public BankAccount(string accountNumber)
        {
            this.AccountNumber = accountNumber;
            this.balance = 0;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
                Console.WriteLine($"Пополнение: {amount}Р");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= this.balance)
            {
                this.balance -= amount;
                Console.WriteLine($"Снятие: {amount}Р");
            }
            else
            {
                Console.WriteLine("Недостаточно средств!");
            }
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Текущий баланс: {this.balance}Р");
        }
    }
}
