
#region Task

//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today


Console.WriteLine("Enter your birthday (yyyy-mm-dd):");

if (!DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
{
    Console.WriteLine("Invalid date!");
    return;
}

int age = AgeCalculator(birthday);
Console.WriteLine($"Your age is: {age}");


static int AgeCalculator( DateTime birthday)
{
    DateTime today = DateTime.Now;
    int age = today.Year - birthday.Year;

    if( today.Month < birthday.Month || (today.Month == birthday.Month &&  today.Day < birthday.Day  ))
    {
        age--;
    }

    return age;
}


#endregion
