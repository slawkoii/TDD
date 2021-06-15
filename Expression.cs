using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestCashConverter
{
    public interface Expression
    {
        Money Reduce(string to);
    }
}
