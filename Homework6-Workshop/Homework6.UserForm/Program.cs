using Homework6.UserForm.Models;

User[] users = new User[]
{
    new User(1, "bob", "123", new string[] { "Hello Bob", "Welcome back!" }),
    new User(2, "anna", "456", new string[] { "Hi Anna" }),
    new User(3, "john", "789", new string[] { "Welcome!" })
};

Console.WriteLine("Choose option:");
Console.WriteLine("1. Login");
Console.WriteLine("2. Register");

bool isParsedChoice = int.TryParse(Console.ReadLine(), out int choice);


if (!isParsedChoice)
{
    Console.WriteLine("Invalid input!");
    return;
}

static User FindUser(User[] users, string username)
{
    foreach (var user in users)
    {
        if (user.Username == username)
        {
            return user;
        }
    }
    return null;
}

static void Login(User[] users)
{
    Console.WriteLine("Enter username:");
    string username = Console.ReadLine();

    Console.WriteLine("Enter password:");
    string password = Console.ReadLine();


    User foundUser = FindUser(users, username);

    if (foundUser != null && foundUser.Password == password)
    {
        Console.WriteLine($"Welcome {foundUser.Username}. Here are your messages:");

        foreach (string msg in foundUser.Messages)
        {
            Console.WriteLine(msg);
        }
    }
    else
    {
        Console.WriteLine("User not found or wrong password!");
    }
}

static User[] Register(User[] users)
{
    Console.WriteLine("Enter ID:");


    bool isParsedId = int.TryParse(Console.ReadLine(), out int id);
    if (!isParsedId)
    {
        Console.WriteLine("Invalid ID!");
        return users;
    }

    Console.WriteLine("Enter username:");
    string username = Console.ReadLine();


    if (FindUser(users, username) != null)
    {
        Console.WriteLine("User already exists!");
        return users;
    }

    Console.WriteLine("Enter password:");
    string password = Console.ReadLine();

    User newUser = new User(id, username, password, new string[] { });


    User[] newArray = new User[users.Length + 1];

    for (int i = 0; i < users.Length; i++)
    {
        newArray[i] = users[i];
    }

    newArray[newArray.Length - 1] = newUser;

    Console.WriteLine("Registration complete! Users:");

    foreach (User user in newArray)
    {
        Console.WriteLine($"{user.Id} {user.Username}");
    }

    return newArray;
}

if (choice == 1)
{
    Login(users);
}
else if (choice == 2)
{
    users = Register(users);
}
else
{
    Console.WriteLine("Invalid choice!");
}