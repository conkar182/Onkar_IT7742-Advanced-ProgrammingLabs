namespace BankApp
{
    public class EverydayAccount : Account
    {
        public EverydayAccount(int id, decimal opening)
            : base(id, opening, 0, 0, 0) { }

        public override void CalculateInterest()
        {
            SetLastMessage($"Interest Added: 0.00; Balance: {GetBalance():0.00}");
        }
    }
}
