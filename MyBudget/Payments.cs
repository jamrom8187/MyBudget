using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget
{
    class Payments
    {

        public static decimal addPayments (List<decimal> amounts)
        {
            decimal newAmount = amounts.Sum();
           return newAmount;
        }

        

       

    }
}
