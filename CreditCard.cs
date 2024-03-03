using System;
namespace Lab3
{
    class CreditCard
    {
        public string CardNumber;
        public string CardHolderName;
        public string Cvc;
        public DateTime ExpirationDate;

        public CreditCard(string CardNumber, string CardHolderName, string Cvc, DateTime ExpirationDate)
        {
            if (string.IsNullOrWhiteSpace(CardNumber) || CardNumber.Length != 16 || !IsDigitsOnly(CardNumber))
                throw new ArgumentException("Invalid card number");

            if (string.IsNullOrWhiteSpace(CardHolderName))
                throw new ArgumentException("Invalid card holder name");

            if (string.IsNullOrWhiteSpace(Cvc) || Cvc.Length != 3 || !IsDigitsOnly(Cvc))
                throw new ArgumentException("Invalid Cvc");

            if (ExpirationDate < DateTime.Now)
                throw new ArgumentException("Expiration date should be in the future");

            this.CardNumber = CardNumber;
            this.CardHolderName = CardHolderName;
            this.Cvc = Cvc;
            this.ExpirationDate = ExpirationDate;
        }

        
        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
