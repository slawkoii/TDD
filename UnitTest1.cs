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
            Assert.IsTrue(Money.Franc(5).equals(Money.Franc(5)));
            Assert.IsFalse(Money.Franc(5).equals(Money.Franc(6)));
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
    }
}