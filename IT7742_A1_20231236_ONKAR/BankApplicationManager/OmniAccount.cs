namespace BankApp
{
    public class OmniAccount : Account
    {
        public OmniAccount(int id, decimal opening, decimal rate, decimal overdraft, decimal failedFee)
            : base(id, opening, rate, overdraft, failedFee) { }

        public override void CalculateInterest()
        {
            var basePart = GetBalance() > 1000 ? GetBalance() - 1000 : 0;
            var add = basePart * (Rate() / 100m);
            SetBalance(GetBalance() + add);
            SetLastMessage($"Interest Added: {add:0.00}; Balance: {GetBalance():0.00}");
        }
    }
}
