using Homework6.ATM.Models;


List<Customer> customers = new List<Customer>()
{
    new Customer("Bob Smith", "1111", 1234, 1000),
    new Customer("Anna Brown", "2222", 4321, 2000)
};

while (true)
{
    Console.WriteLine("1. Login");
    Console.WriteLine("2. Register");
    Console.WriteLine("3. Exit");

    int.TryParse(Console.ReadLine(), out int mainChoice);

    if (mainChoice == 1)
    {
        Customer loggedIn = Authenticate(customers);

        if (loggedIn == null)
        {
            Console.WriteLine("Wrong card or pin!");
            continue;
        }

        Console.WriteLine($"Welcome {loggedIn.FullName}");

        string again;
        do
        {
            int choice = ShowMenu();

            switch (choice)
            {
                case 1:
                    CheckBalance(loggedIn);
                    break;
                case 2:
                    Withdraw(loggedIn);
                    break;
                case 3:
                    Deposit(loggedIn);
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

            Console.WriteLine("Do you want another action? (y/n)");
            again = Console.ReadLine();

        } while (again.ToLower() == "y");
    }
    else if (mainChoice == 2)
    {
        Register(customers);
    }
    else if (mainChoice == 3)
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice!");
    }
}


Customer Authenticate(List<Customer> customers)
{
    Console.WriteLine("Enter card number:");
    string card = Console.ReadLine();

    Console.WriteLine("Enter pin:");
    bool isParsed = int.TryParse(Console.ReadLine(), out int pin);

    if (!isParsed) return null;

    foreach (var c in customers)
    {
        if (c.CardNumber == card && c.CheckPin(pin))
        {
            return c;
        }
    }

    return null;
}

int ShowMenu()
{
    Console.WriteLine("1. Check Balance");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. Deposit");
    Console.WriteLine("4. Logout");

    int.TryParse(Console.ReadLine(), out int choice);
    return choice;
}

void CheckBalance(Customer c)
{
    Console.WriteLine($"Your balance is: {c.GetBalance()}");
}

void Deposit(Customer c)
{
    Console.WriteLine("Enter amount:");
    bool isParsed = double.TryParse(Console.ReadLine(), out double amount);

    if (!isParsed || amount <= 0)
    {
        Console.WriteLine("Invalid amount!");
        return;
    }

    c.Deposit(amount);
    Console.WriteLine("Money deposited.");
}

void Withdraw(Customer c)
{
    Console.WriteLine("Enter amount:");
    bool isParsed = double.TryParse(Console.ReadLine(), out double amount);

    if (!isParsed || amount <= 0)
    {
        Console.WriteLine("Invalid amount!");
        return;
    }

    if (c.Withdraw(amount))
    {
        Console.WriteLine("Money withdrawn.");
    }
    else
    {
        Console.WriteLine("Not enough balance!");
    }
}

void Register(List<Customer> customers)
{
    Console.WriteLine("Enter full name:");
    string name = Console.ReadLine();

    Console.WriteLine("Enter card number:");
    string card = Console.ReadLine();

    foreach (var c in customers)
    {
        if (c.CardNumber == card)
        {
            Console.WriteLine("Card already exists!");
            return;
        }
    }

    Console.WriteLine("Enter pin:");
    bool isParsed = int.TryParse(Console.ReadLine(), out int pin);

    if (!isParsed)
    {
        Console.WriteLine("Invalid PIN!");
        return;
    }

    customers.Add(new Customer(name, card, pin, 0));
    Console.WriteLine("Registration successful!");
}