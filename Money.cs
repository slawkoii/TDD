using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestCashConverter
{
    public abstract class Money
    {
        public int amount;
        public string currency;
     
        public bool equals(Object object1)
        {
            Money money = (Money)object1;
            return amount == money.amount && GetType().Equals(money.GetType());
        }

        public Money(int amount, string currency) 
        {
            this.amount = amount;
            this.currency = currency;
        }

        public abstract Money Times(int multipleer);

        

        internal static Money Dollar(int amount)
        {
            return  new Dollar(amount,"USD");
        }

        internal static Money Franc (int amount)
        {
            return new Franc(amount,"CHF");
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

        public string Currency()
        {
            return this.currency;
        }
    }
}
