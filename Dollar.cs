using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestCashConverter
{
    public class Dollar : Money
    {
        

        public Dollar(int amount)
        {
            this.amount = amount;
        }        

        public Dollar Times(int multipleer)
        {
           return new Dollar(amount * multipleer);
        }
        public override string ToString()
        {
            return "$" + amount;
        }

      

    }
}
