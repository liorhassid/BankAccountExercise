using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class ServiceChargeChecking : CheckingAccount
    {
        public int MonthlyCharge { get; set; }

        public ServiceChargeChecking(string accountName, string id, double balance)
            : base(accountName, id, balance)
        {
            this.MonthlyCharge = 300;
        }

        public ServiceChargeChecking(string accountName, string id, double balance, int monthlyCharge)
            : base(accountName, id, balance)
        {
            this.MonthlyCharge = monthlyCharge;
        }

        public override void MonthlyManagement()
        {
            this.Balance -= MonthlyCharge;
            Console.WriteLine(Balance);
        }
    }
}
