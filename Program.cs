using System;

namespace Lab1_AdvancedProgramming_Onkar
{
    // Exercise 1 and 2: Vehicle class (same as Car example)
    class Vehicle
    {
        // auto properties
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }

        // constructor to set all values
        public Vehicle(string brand, string type, int year)
        {
            Brand = brand;
            Type = type;
            Year = year;
        }

        // show vehicle info
        public void ShowDetails()
        {
            Console.WriteLine("Vehicle Info -> " + Year + " " + Brand + " " + Type);
        }

        // start method
        public void Start()
        {
            Console.WriteLine("Vehicle engine is now running.");
        }
    }

    // Exercise 3: Novel class
    class Novel
    {
        public string Title { get; set; }
        public string Writer { get; set; }
        public int TotalPages { get; set; }

        public void BeginReading()
        {
            Console.WriteLine("Reading book: " + Title + " by " + Writer);
        }
    }

    // Exercise 4: User class with default values
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // default constructor
        public User()
        {
            Name = "Jane Smith";
            Age = 25;
        }

        public void PrintUser()
        {
            Console.WriteLine("User name: " + Name + ", Age: " + Age);
        }
    }

    // Exercise 5: Calculator
    class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        public double Add(double x, double y)
        {
            return x + y;
        }
    }

    // Exercise 6: Static member 
    class Tracker
    {
        private static int total = 0;

        public void AddOne()
        {
            total++;
        }

        public static int GetTotal()
        {
            return total;
        }
    }

    // ATM System 
    class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }

        public BankAccount(string holder, double startBalance)
        {
            AccountHolder = holder;
            Balance = startBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("Deposited " + amount + ". New balance: " + Balance);
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Withdrew " + amount + ". Balance left: " + Balance);
            }
            else
            {
                Console.WriteLine("Not enough funds for " + AccountHolder);
            }
        }
    }

    class ATM
    {
        public string Location { get; set; }

        public ATM(string location)
        {
            Location = location;
        }

        public void UseATM(BankAccount acc)
        {
            Console.WriteLine("ATM at " + Location + " accessed by " + acc.AccountHolder);
        }
    }

    // main
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1 and 2
            Vehicle v1 = new Vehicle("Ford", "Mustang", 2024);
            v1.ShowDetails();
            v1.Start();

            Console.WriteLine();

            // Exercise 3
            Novel n1 = new Novel();
            n1.Title = "Test Book";
            n1.Writer = "Onkar Singh";
            n1.TotalPages = 150;
            n1.BeginReading();

            Console.WriteLine();

            // Exercise 4
            User u1 = new User();
            u1.PrintUser();

            Console.WriteLine();

            // Exercise 5
            Calculator tool = new Calculator();
            Console.WriteLine("Add int (2,3): " + tool.Add(2, 3));
            Console.WriteLine("Add int (1,2,3): " + tool.Add(1, 2, 3));
            Console.WriteLine("Add double (2.5,3.5): " + tool.Add(2.5, 3.5));

            Console.WriteLine();

            // Exercise 6
            Tracker t1 = new Tracker();
            Tracker t2 = new Tracker();
            t1.AddOne();
            t2.AddOne();
            Console.WriteLine("Total count: " + Tracker.GetTotal());

            Console.WriteLine();

            // ATM and BankAccount
            BankAccount acc1 = new BankAccount("David", 1000);
            ATM atm1 = new ATM("Downtown");
            atm1.UseATM(acc1);
            acc1.Deposit(500);
            acc1.Withdraw(300);
            acc1.Withdraw(1500); // shows insufficient funds

            Console.WriteLine("Completed. Press E to exit");
            Console.ReadKey();
        }
    }
}
