Console.WriteLine("Enter the first number: ");
bool isParsed1 = double.TryParse(Console.ReadLine(), out double number1);

Console.WriteLine("Enter the second number: ");
bool isParsed2 = double.TryParse(Console.ReadLine(), out double number2);

Console.WriteLine("Enter the third number: ");
bool isParsed3 = double.TryParse(Console.ReadLine(), out double number3);

Console.WriteLine("Enter the fourth number: ");
bool isParsed4 = double.TryParse(Console.ReadLine(), out double number4);

if (!isParsed1 || !isParsed2 || !isParsed3 || !isParsed4)
{
    Console.WriteLine("Invalid input! Please enter valid input.");
    return;
}

double average = (number1 + number2 + number3 + number4) / 4;

Console.WriteLine("The average of " + number1 + ", " + number2 + ", " + number3 + " and " + number4 + " is: " + average);