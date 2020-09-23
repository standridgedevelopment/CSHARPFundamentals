using System;
using Interfaces_WorkingWithDl.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interfaces_WorkingWithDl
{
    [TestClass]
    public class TransactionTests
    {
        private decimal _debt;
        private void PayDebt(ICurrency payment)
        {
            _debt -= payment.Value;
            Console.WriteLine($"You have paid {payment.Value} towards your debt. Congrats!");
        }
        [TestInitialize]
        public void Arrange()
        {
            _debt = 42000m;
        }
        [TestMethod]
        public void PayDebtTest()
        {
            PayDebt(new Dollar());
            PayDebt(new Dime());
            PayDebt(new ElectronicPayment(475m));
            decimal debt = _debt;
            Console.WriteLine(debt);
        }
        [TestMethod]
        public void InjectingIntoConstructors()
        {
            var dollar = new Dollar();
            var epayment = new ElectronicPayment(52000m);
            var firstTransaction = new Transaction(dollar);
            var secondTransaction = new Transaction(epayment);
            Console.WriteLine(firstTransaction.GetTransactionAmount());
            Console.WriteLine(secondTransaction.GetTransactionAmount());
            
        }
    }
}
