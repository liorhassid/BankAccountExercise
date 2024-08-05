using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Exceptions;

namespace test
{
    public abstract class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string Id { get; set; }
        public double Balance {  get; set; }
        private static int currentAccountNumber = 0;

        public BankAccount(string accountName, string id, double balance)
        {
            AccountNumber = GenerateAccountNumber();
            AccountName = accountName;
            this.Id = id;
            this.Balance = balance;
        }

        public int GenerateAccountNumber()
        {
            return ++currentAccountNumber;
        }

        public virtual void Deposit(int amount)
        {
            Balance += amount;
        }

        public virtual double Witdraw(int amount)
        {
            if(Balance - amount < 0) throw new IllegalBalanceException("balance is lower than 0");

            Balance -= amount;

            return Balance;
        }

        public abstract void MonthlyManagement();

        public override string ToString()
        {
            return "AccountNumber " + AccountNumber + ", AccountName " + AccountName + ", Id " + Id + ", Balance " + Balance;
        }

        public bool Equals(BankAccount other)
        {
            return this.AccountName.Equals(other.AccountName) && this.Id.Equals(other.Id);
        }
    }
}
