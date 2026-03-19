
#region Exercise 4 

Console.WriteLine("Please enter the number of trees: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int numberOfTrees);

int applesOnBranch = 8;
int applesInBasket = 5;
int baskets;

if(!isParsed)
{
    Console.WriteLine("You try to sum values that are not numbers! Please try again");
}
else
{
    int totalApples = numberOfTrees * 12 * applesOnBranch;

    baskets = (totalApples + applesInBasket - 1) / applesInBasket;

    Console.WriteLine(baskets + " baskets are needed for " + numberOfTrees + " trees");
}

#endregion


#region Exercise 5

Console.WriteLine("Enter first number: ");
bool isParsed1 = int.TryParse(Console.ReadLine(), out int num1);

Console.WriteLine("Enter second number: ");
bool isParsed2 = int.TryParse(Console.ReadLine(), out int num2);

if (!isParsed1 || !isParsed2)
{
    Console.WriteLine("Invalid input! Please enter valid numbers.");
    return;
}


if (num1 > num2)
{
    Console.WriteLine("The larger number is " + num1);
}
else if (num2 > num1)
{
    Console.WriteLine("The larger number is " + num2);
}
else
{
    Console.WriteLine("Both numbers are equal");
}


if (num1 % 2 == 0)
{
    Console.WriteLine("The " + num1 + " is even");
}
else
{
    Console.WriteLine("The " + num1 + " is odd");
}

if (num2 % 2 == 0)
{
    Console.WriteLine("The " + num2 + " is even");
}
else
{
    Console.WriteLine("The " + num2 + " is odd");
}

#endregion


#region Exercise 6

Console.WriteLine("Enter the number: ");
bool isParsed3 = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed3)
{
    Console.WriteLine("Invalid input! Please enter valid numbers.");
    return;
}

switch (number)
{
    case 1:
        Console.WriteLine("You got a new car!");
        break;
    case 2:
        Console.WriteLine("You got a new plane!");
        break;
    case 3:
        Console.WriteLine("You got a new bike!");
        break;
    default:
        Console.WriteLine("Error");
        break;
}


#endregion
