using System;

public class SavingsAccount : Account
{
    public override double CalculateInterest()
    {
        return Balance * 0.05;
    }
}
