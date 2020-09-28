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
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the card is valid")]
        public void GivenTheCardIsValid()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the dispenser contains cash")]
        public void GivenTheDispenserContainsCash()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the account is overdrawn")]
        public void GivenTheAccountIsOverdrawn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the customer requests cash")]
        public void WhenTheCustomerRequestsCash()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"ensure the account is debited")]
        public void ThenEnsureTheAccountIsDebited()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"ensure cash is dispensed")]
        public void ThenEnsureCashIsDispensed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"ensure the card is returned")]
        public void ThenEnsureTheCardIsReturned()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"ensure a rejection message is displayed")]
        public void ThenEnsureARejectionMessageIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"ensure cash is not dispensed")]
        public void ThenEnsureCashIsNotDispensed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
