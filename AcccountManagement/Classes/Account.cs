using System;
using System.Collections.Generic;
using System.Text;

namespace AcccountManagement.Classes
{
    public class BankAccount
    {
        private List<Transaction> _alltransactions = new List<Transaction>();
        public int Number { get; }
        public string Owner { get;}
        public decimal Balance { get
            {
                decimal balance = 0m;
                foreach (var transaction in _alltransactions)
                    balance += transaction.Amount;
                return balance;
            }
        }
        private  static int SeedInitialAccountNumber { get; set; } = 1234567890;
        public BankAccount(string name, decimal balance)
        {
            Owner = name;
            Number = SeedInitialAccountNumber;
            MakeDeposit(balance, "Initial Balance");
            SeedInitialAccountNumber++;
        }

        public void MakeDeposit(decimal amount,string note)
        {
            if(amount <= 0m)
            {
                throw new NegativeAmountException("Amount can't be Negative");
            }
            _alltransactions.Add(
                new Transaction() {
                   Amount = amount,
                   TransactionTime = DateTime.Now,
                   Note = note }
                );
        }

        public void MakeWithDraw(decimal amount, string note)
        {
            if (amount < 0m)
            {
                throw new NegativeAmountException("Amount can't be Negative");
            }
            if(Balance - amount < 0)
            {
                throw new InSufficientBalanceException("Insufficient Balance");
            }
            _alltransactions.Add(
                new Transaction()
                {
                    Amount = -amount,
                    TransactionTime = DateTime.Now,
                    Note = note
                }
                );
        }
    }
}
