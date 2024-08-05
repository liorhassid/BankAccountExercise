using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount c1 = new CheckingAccount("lior", "123456789", 1200);
            CheckingAccount c2 = new CheckingAccount("roei", "444456788", 500);
            c1.TransferMoney(100, c2);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            ServiceChargeChecking s1 = new ServiceChargeChecking("ilay", "77777777", 1000);
            s1.MonthlyManagement();
            Console.WriteLine(s1.ToString());
            NoServiceChargeChecking n1 = new NoServiceChargeChecking("avi", "99999999", 3000);
            n1.TransferMoney(2500, s1);
            n1.MonthlyManagement();
            Console.WriteLine(n1.ToString());
            SpecialPopulationAccount sp1 = new SpecialPopulationAccount("nitay", "000000000", 200);
            sp1.MonthlyManagement();
            Console.WriteLine(sp1.ToString());
            YouthAccount y1 = new YouthAccount("bobi", "764697797", 10000);
            y1.TransferMoney(400, c1);
            y1.Witdraw(150);
            y1.Deposit(300);
            c1.TransferMoney(200, y1);
            y1.MonthlyManagement();
            Console.WriteLine(y1.ToString());
        }

    }
}
