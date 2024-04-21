using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bankacc
{
    public class BankAccount
    {
        public int id;
        public double balance;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit(double amount)
        {
            this.balance += amount;
        }
        public void WithDraw(double amount)
        {
            this.balance -= amount;
        }
        public void Print()
        {
            Console.WriteLine($"Account {this.Id}, Balance {this.Balance}.");
        }
    }
}
