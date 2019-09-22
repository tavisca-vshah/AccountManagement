using System;

namespace AcccountManagement.Classes
{
    public class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime TransactionTime { get; set; }
        public string Note { get; set; }
    }
}