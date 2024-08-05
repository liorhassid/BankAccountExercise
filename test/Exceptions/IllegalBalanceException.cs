using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Exceptions
{
    public class IllegalBalanceException : Exception
    {
        public IllegalBalanceException()
        {

        }

        public IllegalBalanceException(string message)
            : base(message)
        {
        }
    }
}
