using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestCashConverter
{
    public class Money
    {
        public int amount;

        public bool equals(Object object1)
        {
            Money money = (Money)object1;
            return amount == money.amount && GetType().Equals(money.GetType());
        }

        public override bool Equals(object obj)
        {
            Money other = obj as Money;
            if (other == null)
                return false;

            return amount == other.amount;
        }

        public override int GetHashCode()
        {
            return amount.GetHashCode();
        }
    }
}
