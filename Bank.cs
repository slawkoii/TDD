using System.Collections;

namespace NUnitTestCashConverter
{
    public class Bank
    {
        private Hashtable rates = new Hashtable();
        public Money Reduce(IExpression sourse, string to)
        {
            if (sourse.GetType() == typeof(Money)) return (Money)sourse.Reduce(this, to);
            return sourse.Reduce(this, to);
        }

        internal void AddRate(string from, string to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }

        public int Rate(string from, string to)
        {
            if (from.Equals(to)) return 1;
            int rate = (int)rates[(new Pair(from, to))];
            return rate;
        }
    }

    internal class Pair
    {
        private string from;
        private string to;

        public Pair(string from, string to)
        {
            this.from = from;
            this.to = to;
        }

        public int HashCode()
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            Pair pair = (Pair)obj;
            return from.Equals(pair.from) && to.Equals(pair.to);
        }

        public override int GetHashCode()
        {
            return HashCode().GetHashCode();
        }
    }
}