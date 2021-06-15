using System;

namespace NUnitTestCashConverter
{
    public class Sum : Expression
    {
        public Money augend;
        public Money addend;

        public Sum(Money augend, Money addend)
        {
            this.augend = augend;
            this.addend = addend;
        }     

       

        Money Expression.Reduce(string to)
        {
            int amount = addend.amount + augend.amount;
            return new Money(amount, to);
        }
    }
}