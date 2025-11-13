namespace BankApp
{
    public abstract class Account
    {
        private int _accountID;
        private decimal _balance;
        private decimal _interestRate;
        private decimal _overdraftLimit;
        private decimal _failedFee;
        private string _lastMessage = "";

        protected Account(int id, decimal opening, decimal rate, decimal overdraft, decimal failedFee)
        {
            _accountID = id;
            _balance = opening;
            _interestRate = rate;
            _overdraftLimit = overdraft;
            _failedFee = failedFee;
        }

        public int GetAccountID() => _accountID;
        public decimal GetBalance() => _balance;
        public string Last() => _lastMessage;

        protected void SetBalance(decimal v) => _balance = v;
        protected decimal Rate() => _interestRate;
        protected decimal Overdraft() => _overdraftLimit;
        protected decimal FailedFee() => _failedFee;
        protected void SetLastMessage(string msg) => _lastMessage = msg;

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                _lastMessage = $"Deposit ignored: {amount}";
                return;
            }
            _balance += amount;
            _lastMessage = $"Deposit: {amount:0.00}; Balance: {_balance:0.00}";
        }

        public void Withdraw(decimal amount, bool isStaff)
        {
            if (amount <= 0)
            {
                _lastMessage = $"Withdraw ignored: {amount}";
                return;
            }

            if (!CanWithdraw(amount))
            {
                var fee = isStaff ? FailedFee() / 2 : FailedFee();
                if (fee > 0)
                {
                    _balance -= fee;
                    _lastMessage = $"Withdrawal Failed: {amount:0.00}; Fee: {fee:0.00}; Balance: {_balance:0.00}";
                }
                else
                {
                    _lastMessage = $"Withdrawal Failed: {amount:0.00}; Balance: {_balance:0.00}";
                }
                return;
            }

            _balance -= amount;
            _lastMessage = $"Withdraw: {amount:0.00}; Balance: {_balance:0.00}";
        }

        protected virtual bool CanWithdraw(decimal amount)
        {
            var minAllowed = -Overdraft();
            return GetBalance() - amount >= minAllowed;
        }

        public abstract void CalculateInterest();

        public string AccountInfo()
        {
            return $"{GetType().Name} {_accountID}; Rate {Rate():0.##}% | OD {Overdraft():0.##} | Fee {FailedFee():0.##} | Balance {_balance:0.00} | Last: {_lastMessage}";
        }
    }
}
