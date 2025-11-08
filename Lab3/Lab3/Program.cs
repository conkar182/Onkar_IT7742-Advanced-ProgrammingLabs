using System;
using System.Collections.Generic;

namespace Lab3_AbstractClasses_StudentB
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Exercise 5: Vehicle ===");
            Vehicle v1 = new Car();
            Vehicle v2 = new Motorcycle();
            v1.StartEngine();
            v1.StopEngine();
            v2.StartEngine();
            v2.StopEngine();

            Console.WriteLine("\n=== Exercise 6: Shape ===");
            Circle circle = new Circle { Radius = 5 };
            Rectangle rect = new Rectangle { Width = 4, Height = 6 };
            circle.Display();
            rect.Display();

            Console.WriteLine("\n=== Exercise 7: Appliance ===");
            List<Appliance> devices = new List<Appliance>
            {
                new WashingMachine(),
                new Refrigerator()
            };
            foreach (Appliance a in devices)
            {
                a.Operate();
            }

            Console.WriteLine("\n=== Exercise 8: Account ===");
            SavingsAccount s = new SavingsAccount { AccountNumber = "SA300", Balance = 2500 };
            CheckingAccount c = new CheckingAccount { AccountNumber = "CA400", Balance = 1800 };
            s.DisplayAccountInfo();
            Console.WriteLine("Interest: " + s.CalculateInterest());
            c.DisplayAccountInfo();
            Console.WriteLine("Interest: " + c.CalculateInterest());

            Console.WriteLine("\n--- End of Lab 3 Output  ---");
        }
    }
}
