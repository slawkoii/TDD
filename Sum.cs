﻿namespace NUnitTestCashConverter
{
    public class Sum : Expression
    {
        public Expression augend;
        public Expression addend;

        public Sum(Expression augend, Expression addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public Expression Plus(Expression addend)
        {
            return new Sum(this, addend);
        }

        public Expression Times(int multiplier)
        {
            return new Sum(augend.Times(multiplier), addend.Times(multiplier));
        }

        Money Expression.Reduce(Bank bank, string to)
        {
            int amount = addend.Reduce(bank, to).amount + augend.Reduce(bank, to).amount;
            return new Money(amount, to);
        }
    }
}