using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestCashConverter
{
    public class Franc : Money
    {
       

        public Franc(int amount)
        {
            this.amount = amount;
        }
        public Franc Times(int multipleer)
        {
            return new Franc(amount * multipleer);
        }

        public override string ToString()
        {
            return "$" + amount;
        }
        


    }
}
