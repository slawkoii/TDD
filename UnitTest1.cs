using NUnit.Framework;
using System;

namespace NUnitTestCashConverter
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMultiplication()
        {
            Money five = Money.Dollar(5);                      
            Assert.AreEqual(Money.Dollar(10), five.Times(2));            
            Assert.AreEqual(Money.Dollar(15), five.Times(3));
        }

        [Test]

        public void TestEquality()
        {
            Assert.IsTrue(Money.Dollar(5).equals(Money.Dollar(5)));
            Assert.IsFalse(Money.Dollar(5).equals(Money.Dollar(6)));                
            Assert.IsFalse(Money.Franc(5).equals(Money.Dollar(5)));
        }

        [Test]
        public void TestFrancMultiplication()
        {
            Money five = Money.Franc(5);
            Assert.AreEqual(Money.Franc(10), five.Times(2));
            Assert.AreEqual(Money.Franc(15), five.Times(3));
        }

        [Test]

        public void TestCurrency()
        {
            Assert.AreEqual("USD",Money.Dollar(1).Currency());
            Assert.AreEqual("CHF", Money.Franc(1).Currency());
        }

       [Test]

       public void TestSimpleAddition()
        {
            Money five = Money.Dollar(5);
            Expression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(10), reduced);
        }

        [Test]

        public void TestPlusReturnSum()
        {
            Money five = Money.Dollar(5);
            Expression sum = five.Plus(five);
           // Sum sum = (Sum)result;
          //  Assert.AreEqual(five, sum.augend);
          //  Assert.AreEqual(five, sum.addend);
        }
        
        [Test]

        public void TestReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.Reduce(Money.Dollar(1), "USD");
            Assert.AreEqual(Money.Dollar(1), result);
        }

        [Test]

        public void TestReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.Franc(2), "USD");
            Assert.AreEqual(Money.Dollar(1), result);
        }
    }
}