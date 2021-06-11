using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestCashConverter
{
    public class Dollar : Money
    {
        
        public Dollar(int amount,string currency) : base(amount,currency)
        {
            
        }

        

        public override Money Times(int multipleer)
        {
           return Money.Dollar(amount * multipleer);
        }
        public override string ToString()
        {
            return "$" + amount;
        }

        
    }
}
