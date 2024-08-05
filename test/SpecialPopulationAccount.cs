using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class SpecialPopulationAccount : ServiceChargeChecking
    {

        public int Income { get; set; }

        public SpecialPopulationAccount(string accountName, string id, double balance)
            : base(accountName, id, balance)
        {
            MonthlyCharge = 49;
            Income = 79;
        }

        public SpecialPopulationAccount(string accountName, string id, double balance, int monthlyCharge, int income)
            : base(accountName, id, balance)
        {
            this.MonthlyCharge = monthlyCharge;
            this.Income = income;
        }

        public override void MonthlyManagement()
        {
            this.Balance -= MonthlyCharge;
            this.Balance += Income;
            Console.WriteLine(Balance);
        }
    }
}
