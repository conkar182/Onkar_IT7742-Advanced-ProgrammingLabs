using System;
using System.Windows.Forms;
using BankApp;

namespace BankApplicationForm
{
    public partial class Form1 : Form
    {
        private readonly Customer cust;
        private readonly EverydayAccount every;
        private readonly InvestmentAccount invest;
        private readonly OmniAccount omni;

        public Form1()
        {
            InitializeComponent();

            // seed sample data
            cust = new Customer(1, "Demo User", "demo@x.com", isStaff: true);
            every = new EverydayAccount(11, 300m);
            invest = new InvestmentAccount(23, 620m, rate: 0.04m, failedFee: 10m);
            omni = new OmniAccount(67, 1320.43m, rate: 0.04m, overdraft: 100m, failedFee: 10m);

            if (cbo.Items.Count == 0)
            {
                cbo.Items.AddRange(new object[] { "Everyday", "Investment", "Omni" });
                cbo.SelectedIndex = 0;
            }
        }

        private Account Current() => cbo.SelectedIndex switch
        {
            0 => every,
            1 => invest,
            _ => omni
        };

        private decimal ParseAmt()
        {
            if (!decimal.TryParse(txtAmount.Text, out var v))
            {
                lst.Items.Add("Please enter a number.");
                return 0m;
            }
            return v;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            var a = Current();
            var m = ParseAmt();
            if (m <= 0) return;
            a.Deposit(m);
            lst.Items.Add(a.Last());
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            var a = Current();
            var m = ParseAmt();
            if (m <= 0) return;
            a.Withdraw(m, cust.IsStaff());
            lst.Items.Add(a.Last());
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            var a = Current();
            a.CalculateInterest();
            lst.Items.Add(a.Last());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            var a = Current();
            lst.Items.Add($"Account {a.GetAccountID()} Balance: {a.GetBalance():C}");
        }
    }
}
