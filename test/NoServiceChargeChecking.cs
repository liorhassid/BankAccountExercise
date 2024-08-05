using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Exceptions;

namespace test
{
    public class NoServiceChargeChecking : CheckingAccount
    {

        public int MinimumForBalance { get; set; }

        public NoServiceChargeChecking(string accountName, string id, double balance)
            : base(accountName, id, balance)
        {
            this.MinimumForBalance = 500;
        }

        public NoServiceChargeChecking(string accountName, string id, double balance, int minimumForCharge)
            : base(accountName, id, balance)
        {
            this.MinimumForBalance = minimumForCharge;
        }

        public override double Witdraw(int amount)
        {
            if (Balance - amount < MinimumForBalance) throw new IllegalBalanceException("balance is lower than MinimumForCharge");

            Balance -= amount;

            return Balance;
        }

        public override void MonthlyManagement()
        {
            Console.WriteLine(Balance - MinimumForBalance);
        }
    }
}
