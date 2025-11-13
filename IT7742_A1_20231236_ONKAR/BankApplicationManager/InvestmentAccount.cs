namespace BankApp
{
    public class InvestmentAccount : Account
    {
        public InvestmentAccount(int id, decimal opening, decimal rate, decimal failedFee)
            : base(id, opening, rate, 0, failedFee) { }

        public override void CalculateInterest()
        {
            var add = GetBalance() * (Rate() / 100m);
            SetBalance(GetBalance() + add);
            SetLastMessage($"Interest Added: {add:0.00}; Balance: {GetBalance():0.00}");
        }

        protected override bool CanWithdraw(decimal amount)
        {
            return GetBalance() - amount >= 0;
        }
    }
}
