using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Exceptions;

namespace test
{
    public class YouthAccount : SpecialPopulationAccount
    {

        private double WitdrawSummary;
        private double DepositSummary;
        private static int witdraws = 0;
        private static int deposits = 0;

        public YouthAccount(string accountName, string id, double balance)
            : base(accountName, id, balance)
        {
            this.MonthlyCharge = 0;
            this.Income = 45;
        }

        public override double Witdraw(int amount)
        {
            if(amount > 400) throw new IllegalBalanceException("YouthAccount can not witdraw more than 400");

            if (Balance - amount < 0) throw new IllegalBalanceException("balance is lower than 0");

            witdraws++;
            WitdrawSummary += amount;
            Balance -= amount;

            return Balance;
        }

        public override void Deposit(int amount)
        {
            deposits++;
            DepositSummary += amount;
            Balance += amount;
        }

        public override void MonthlyManagement()
        {
            Balance += Income;
            if(witdraws > 0 && deposits > 0)
            {
                Console.WriteLine("Witdraw average: " + WitdrawSummary / witdraws + ", Deposit average: " + DepositSummary / deposits);
            }
            else if(witdraws > 0)
            {
                Console.WriteLine("Witdraw average: " + WitdrawSummary / witdraws + ", Deposit average: 0");
            }
            else if(deposits > 0)
            {
                Console.WriteLine("Witdraw average: 0 , Deposit average: " + DepositSummary / deposits);
            }
            else Console.WriteLine("Witdraw average: 0 , Deposit average: 0");
            deposits = 0; witdraws = 0; DepositSummary = 0; WitdrawSummary = 0;
        }
    }
}
