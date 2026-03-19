Console.WriteLine("Enter the first number: ");
bool isParsed1 = int.TryParse(Console.ReadLine(), out int number1);

Console.WriteLine("Enter the second number: ");
bool isParsed2 = int.TryParse(Console.ReadLine(), out int number2);

if (!isParsed1 || !isParsed2)
{
    Console.WriteLine("Invalid input! Please enter valid input.");
    return;
}

int temp = number1;
number1 = number2;
number2 = temp;

Console.WriteLine("After swapping:");
Console.WriteLine("First number: " + number1);
Console.WriteLine("Second number: " + number2);