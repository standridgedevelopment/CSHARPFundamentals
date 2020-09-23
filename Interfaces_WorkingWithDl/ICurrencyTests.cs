using System;
using Interfaces_WorkingWithDl.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interfaces_WorkingWithDl
{
    [TestClass]
    public class ICurrencyTests
    {
        [TestMethod]
        public void PennyTests()
        {
            var penny = new Penny();
            Assert.AreEqual(0.01m, penny.Value);
        }
        [DataTestMethod]
        [DataRow(100.02)]
        [DataRow(.52)]
        [DataRow(42.42)]
        [DataRow(6000.001)]
        [DataRow(19)]
        [DataRow(37.2065)]
        public void EPaymentTests(double value)
        {
            decimal convertedValue = Convert.ToDecimal(value);
            var ePayment = new ElectronicPayment(convertedValue);
            Assert.AreEqual(convertedValue, ePayment.Value);
            Assert.AreEqual("Electronic Payment", ePayment.Name);
        }

    }
}
