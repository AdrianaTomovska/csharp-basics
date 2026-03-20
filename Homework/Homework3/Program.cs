
#region Exercise 1

using System.Threading.Channels;
using System.Xml.Linq;

Console.WriteLine("Enter the number");
bool isParsed1 = int.TryParse(Console.ReadLine(), out int number1);

if (!isParsed1)
{
    Console.WriteLine("You try to sum values that are not numbers! Please try again");
}
else
{
    for (int i = 0; i < number1; i++)
    {
        Console.WriteLine("Iteration no. " + i);

    }

    Console.ReadLine();

    Console.WriteLine("Enter the number");
    bool isParsed2 = int.TryParse(Console.ReadLine(), out int number2);

    if (!isParsed2)
    {
        Console.WriteLine("You try to sum values that are not numbers! Please try again");
    }
    else
    {
        for (int i = number2; i >= 1; i--)
        {
            Console.WriteLine("Iteration no. " + i);
        }

    }

    Console.ReadLine();

    Console.WriteLine("Enter the number");
    bool isParsed3 = int.TryParse(Console.ReadLine(), out int number3);

    if (!isParsed3)
    {
        Console.WriteLine("You try to sum values that are not numbers! Please try again");
        return;
    }
    Console.Write("Even numbers (starting from 2): ");
    for (int i = 2; i < number3; i += 2)
    {
        Console.WriteLine(i + " evan");
    }
    Console.Write("Odd numbers (starting from 1): ");
    for (int i = 1; i < number3; i += 2)
    {
        Console.WriteLine(i + " odd");
    }

}

#endregion


#region Exercise 2



Console.WriteLine("Enter the number");
bool isParsed4 = int.TryParse(Console.ReadLine(), out int number4);

int j = 1;
if (!isParsed4)
{
    Console.WriteLine("You try to sum values that are not numbers! Please try again");
    return;
}

while (j <= number4)
{
    if (j == 100)
    {
        Console.WriteLine("The limir is reached");
        break;
    }
    if (j % 3 == 0 || j % 7 == 0)
    {
        j++;
        continue;
    }

    Console.WriteLine(j + " ");
    j++;
}

#endregion


#region Exercise 3

string[] stringArray = new string[5]
{
    "Apple",
    "Banana",
    "Lemon",
    "Orange",
    "Kiwi"
};


double[] doubleArray = new double[5]
{
    12.4,
    32.6,
    6.2,
    0.8,
    99.9
};

char[] charArray = new char[5]
{
    '!',
    '@',
    '#',
    '$',
    '%'
};

bool[] boolArray = new bool[5]
{
    true, false,false,true,false
};

int[][] array = new int[][]
{
    new int[] { 1, 2 },
    new int[] { 4, 7 },
    new int[] { 3, 8 },
    new int[] { 5, 9 },
    new int[] { 6, 10 }
};

#endregion


#region Exercise 4

int[] intArray = new int[5];

for (int i = 0; i < intArray.Length; i++)
{
    Console.WriteLine("Enter number " + (i + 1));

    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Invalid input, try again:");
    }
    intArray[i] = num;
}

foreach (int arr in intArray)
{
    Console.WriteLine(arr);
}

int sum = 0;

foreach (var num in intArray)
{
    sum += num;
}

Console.WriteLine("Sum of all values is: " + sum);


#endregion

Console.ReadLine();

#region Exercise 5

string[] names = new string[5];

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine("Enter name " + (i + 1));
    names[i] = Console.ReadLine();
}

while (true)
{
    Console.WriteLine("Do you want to add more names? Y/N");
    string input = Console.ReadLine();

    if (input == "Y" || input == "y")
    {
        Array.Resize(ref names, names.Length + 1);

        Console.WriteLine("Enter new name:");
        string name = Console.ReadLine();

        names[names.Length - 1] = name;
    }
    else if (input == "N" || input == "n")
    {
        break;
    }
}

Console.WriteLine("All names:");
foreach (var nam in names)
{
    Console.WriteLine(nam);
}


#endregion

