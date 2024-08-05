using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountName, string id, double balance)
            : base(accountName, id, balance)
        {
        }

        public override void MonthlyManagement()
        {
            Console.WriteLine(Balance);
        }

        public void TransferMoney(int amount, BankAccount other)
        {
            this.Witdraw(amount);
            other.Deposit(amount);
        }
    }
}
