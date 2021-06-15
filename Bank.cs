using System;

namespace NUnitTestCashConverter
{
    internal class Bank
    {
        internal Money reduce(Expression sourse, string to)
        {
            if (sourse.GetType() == typeof(Money)) return (Money)sourse.Reduce(to);
            Sum sum = (Sum)sourse;
            return sourse.Reduce(to);
        }
    }
}