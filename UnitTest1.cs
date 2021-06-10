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
            Dollar five = new Dollar(5);                      
            Assert.AreEqual(new Dollar(10), five.Times(2));            
            Assert.AreEqual(new Dollar(15), five.Times(3));
        }

        [Test]

        public void testEquality()
        {
            Assert.IsTrue(new Dollar(5).equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).equals(new Dollar(6)));
            Assert.IsTrue(new Franc(5).equals(new Franc(5)));
            Assert.IsFalse(new Franc(5).equals(new Franc(6)));
            Assert.IsFalse(new Franc(5).equals(new Dollar(5)));
        }

        [Test]
        public void TestFrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.AreEqual(new Franc(10), five.Times(2));
            Assert.AreEqual(new Franc(15), five.Times(3));
        }
    }
}