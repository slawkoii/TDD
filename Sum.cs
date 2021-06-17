namespace NUnitTestCashConverter
{
    public class Sum : IExpression
    {
        public IExpression augend;
        public IExpression addend;

        public Sum(IExpression augend, IExpression addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }

        public IExpression Times(int multiplier)
        {
            return new Sum(augend.Times(multiplier), addend.Times(multiplier));
        }

        Money IExpression.Reduce(Bank bank, string to)
        {
            int amount = addend.Reduce(bank, to).amount + augend.Reduce(bank, to).amount;
            return new Money(amount, to);
        }
    }
}