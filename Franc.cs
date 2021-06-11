using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestCashConverter
{
    public class Franc : Money
    {
        
        public Franc(int amount, string currency) : base(amount,currency)
        {
            
        }

        

        public override Money Times(int multipleer)
        {
            return Money.Franc(amount * multipleer);
        }

        public override string ToString()
        {
            return "$" + amount;
        }

        

    }
}
