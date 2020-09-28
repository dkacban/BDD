using System;
using Bank;
using NUnit.Framework;
using TechTalk.SpecFlow;
using ATM = Bank.ATM;

namespace BDDExampleProject.Features
{
    [Binding]
    public class CustomerWithdrawsCashSteps
    {
        public ATM Atm { get; set; } = new ATM();

        [Given(@"the account is in credit")]
        public void GivenTheAccountIsInCredit()
        {
            Atm.Balance = 5000;
        }
        
        [Given(@"the card is valid")]
        public void GivenTheCardIsValid()
        {

            Atm.Card = new Card();
            Atm.Card.IsValid = true;
            Atm.IsCardInserted = true;
        }
        
        [Given(@"the dispenser contains cash")]
        public void GivenTheDispenserContainsCash()
        {
            Atm.DispenserContainsCash = true;
        }
        
        [Given(@"the account is overdrawn")]
        public void GivenTheAccountIsOverdrawn()
        {
            Atm.Balance = 0;
        }
        
        [When(@"the customer requests cash")]
        public void WhenTheCustomerRequestsCash()
        {
            Atm.RequestCash(1000);
        }
        
        [Then(@"ensure the account is debited")]
        public void ThenEnsureTheAccountIsDebited()
        {
            Assert.IsTrue(Atm.Balance > 0);
        }
        
        [Then(@"ensure cash is dispensed")]
        public void ThenEnsureCashIsDispensed()
        {
            Assert.IsTrue(Atm.IsCashDispended);
        }
        
        [Then(@"ensure the card is returned")]
        public void ThenEnsureTheCardIsReturned()
        {
            Assert.IsFalse(Atm.IsCardInserted);
        }
        
        [Then(@"ensure a rejection message is displayed")]
        public void ThenEnsureARejectionMessageIsDisplayed()
        {
            Assert.IsTrue(Atm.IsRejectionMessageDisplayed);
        }
        
        [Then(@"ensure cash is not dispensed")]
        public void ThenEnsureCashIsNotDispensed()
        {
            Assert.IsFalse(Atm.IsCashDispended);
        }
    }
}
