using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestCashConverter
{
    public  class Money : Expression
    {
        internal int amount;
        internal string currency;
     
        public bool equals(Object object1)
        {
            Money money = (Money)object1;
            return amount == money.amount && Currency().Equals(money.Currency());
        }

        public Money(int amount, string currency) 
        {
            this.amount = amount;
            this.currency = currency;
        }

        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }


        internal static Money Dollar(int amount)
        {
            return  new Money(amount,"USD");
        }

        internal static Money Franc (int amount)
        {
            return new Money(amount,"CHF");
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

       public Expression Plus(Money addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(currency, to);
            return new Money(amount / rate,to);
        }
    }
}
