using System;
using System.Collections.Generic;

namespace BankApp
{
    internal class Program
    {
        static void Main()
        {
            var cust = new Customer(1, "Demo User", "demo@x.com", isStaff: true);
            var every = new EverydayAccount(11, 300m);
            var invest = new InvestmentAccount(23, 620m, rate: 4m, failedFee: 10m);
            var omni = new OmniAccount(67, 1320.43m, rate: 4m, overdraft: 100m, failedFee: 10m);

            var map = new Dictionary<int, Account> { { 1, every }, { 2, invest }, { 3, omni } };

            while (true)
            {
                Console.WriteLine("\n1) Everyday  2) Investment  3) Omni  9) Info All  0) Exit");
                Console.Write("Pick: ");
                if (!int.TryParse(Console.ReadLine(), out var pick)) continue;
                if (pick == 0) break;

                if (pick == 9)
                {
                    foreach (var a in map.Values)
                        Console.WriteLine(a.AccountInfo());
                    continue;
                }

                if (!map.TryGetValue(pick, out var acc)) continue;

                Console.WriteLine("a) Deposit  b) Withdraw  c) Add Interest  d) Info");
                Console.Write("Action: ");
                var act = Console.ReadLine();

                if (act == "a")
                {
                    Console.Write("Amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out var amt)) acc.Deposit(amt);
                    Console.WriteLine(acc.Last());
                }
                else if (act == "b")
                {
                    Console.Write("Amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out var amt)) acc.Withdraw(amt, cust.IsStaff());
                    Console.WriteLine(acc.Last());
                }
                else if (act == "c")
                {
                    acc.CalculateInterest();
                    Console.WriteLine(acc.Last());
                }
                else if (act == "d")
                {
                    Console.WriteLine(acc.AccountInfo());
                }
            }
        }
    }
}
