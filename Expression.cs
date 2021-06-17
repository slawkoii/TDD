namespace NUnitTestCashConverter
{
    public interface IExpression
    {
        Money Reduce(Bank bank, string to);
        public IExpression Times(int multiplier);
        public IExpression Plus(IExpression addend);
    }
}
