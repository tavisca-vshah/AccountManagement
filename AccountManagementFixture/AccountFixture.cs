using System;
using Xunit;
using AcccountManagement.Classes;

namespace AccountManagementFixture
{
    public class AccountFixture
    {
        [Fact]
        public void Account_Owner_Should_Be_Able_To_Deposit_Test()
        {
            BankAccount account = new BankAccount("abc", 1000);
            account.MakeDeposit(1000, "Salary");
            Assert.Equal(2000, account.Balance);
        }

        [Fact]
        public void Account_Should_Throw_Exception_While_Deposit_When_Amount_Is_Negative()
        {
            BankAccount account = new BankAccount("Abc", 1000);
            Assert.Throws<NegativeAmountException>(() => account.MakeDeposit(-12, "Salary"));
        }

        [Fact]
        public void Account_Should_Throw_Exception_When_Account_Is_Initilize_With_Negative_Amount()
        {
            
            Assert.Throws<NegativeAmountException>(() =>  new BankAccount("Abc", -1000));
        }

        [Fact]
        public void Account_Owner_Should_Able_To_Withdraw_Amount()
        {
            BankAccount account = new BankAccount("Abc", 1000);
            account.MakeWithDraw(100m, "Rent");
            Assert.Equal(900, account.Balance);
        }
        [Fact]
        public void Account__Should_Throw_Exception_When_InSufficent_Balance_Exist_To_Withdraw_Amount()
        {
            BankAccount account = new BankAccount("Abc", 1000);
            Assert.Throws<InSufficientBalanceException>(() => account.MakeWithDraw(1100m, "Rent"));
            
        }

    }
}
