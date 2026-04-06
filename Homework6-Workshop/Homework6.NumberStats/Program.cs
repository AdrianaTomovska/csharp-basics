


void NumberStats(double num)
{
    Console.WriteLine($"Stats for number: {num}");


    if (num > 0)
    {
        Console.WriteLine("Positive");
    }
    else if (num < 0)
    {
        Console.WriteLine("Negative");
    }
    else
    {
        Console.WriteLine("Zero");
    }


    if (num % 1 == 0)
    {
        Console.WriteLine("Integer");

  
        if ((int)num % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
    else
    {
        Console.WriteLine("Decimal");
    }
}


string again;
do
{
    Console.WriteLine("Enter a number:");
    bool isParsedNum = double.TryParse(Console.ReadLine(), out double num);

    if (!isParsedNum)
    {
        Console.WriteLine("Enter a valid number!");
        return;
    }

NumberStats(num);


    Console.WriteLine("Press Y to try again or X to exit:");
    again = Console.ReadLine();
} while (again.ToUpper() == "Y");

