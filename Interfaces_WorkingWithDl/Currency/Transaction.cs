using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_WorkingWithDl.Currency
{
    public class Transaction
    {
        private readonly ICurrency _currency;
        public DateTimeOffset DateOfTransaction { get; private set; }

        public Transaction(ICurrency currency)
        {
            _currency = currency;
            DateOfTransaction = DateTimeOffset.Now;
        }
        public decimal GetTransactionAmount()
        {
            return _currency.Value;
        }

        public string GetTransactionType() => _currency.Name;
        
    }
}
