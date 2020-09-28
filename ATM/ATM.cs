using System;

namespace Bank
{
    public class ATM
    {
        public Card Card { get; set; }
        public bool IsCardInserted { get; set; }
        public bool IsCashDispended { get; set; }
        public decimal Balance { get; set; }
        public bool IsRejectionMessageDisplayed { get; set; }

        public bool DispenserContainsCash { get; set; }

        public void RequestCash(decimal amount)
        {
            if (Balance - amount > 0)
            {
                Balance -= amount;
                IsCashDispended = true;
            }
            else
            {
                IsRejectionMessageDisplayed = true;
            }

            IsCardInserted = false;
        }
    }

    public class Card
    {
        public bool IsValid { get; set; }
    }
}
