#region Task 1

for (; ; )
{
    Console.WriteLine("Enter the first number: ");
    bool isParsed = double.TryParse(Console.ReadLine(), out double number1);

    Console.WriteLine("Enter the second number: ");
    bool isParsed1 = double.TryParse(Console.ReadLine(), out double number2);

    Console.WriteLine("Enter the operation (+, -, *, /): ");
    bool isParsed2 = char.TryParse(Console.ReadLine(), out char operation);

    if (!isParsed || !isParsed1 || !isParsed2)
    {
        Console.WriteLine("Invalid input! Please enter valid input.");
        continue;
    }

    switch (operation)
    {
        case '+':
            Console.WriteLine(number1 + number2);
            break;

        case '-':
            Console.WriteLine(number1 - number2);
            break;

        case '*':
            Console.WriteLine(number1 * number2);
            break;

        case '/':
            if (number2 == 0)
            {
                Console.WriteLine("Divide by 0 is not possible");
            }
            else
            {
                Console.WriteLine(number1 / number2);
            }
            break;

        default:
            Console.WriteLine("Invalid operation");
            break;
    }


    Console.WriteLine("Do you want to continue? (y/n)");
    string input = Console.ReadLine();

    if (input.ToLower() == "y")
        continue;
    else if (input.ToLower() == "n")
        break;
    else
    {
        Console.WriteLine("Invalid choice, exiting program.");
        break;
    }
}

#endregion