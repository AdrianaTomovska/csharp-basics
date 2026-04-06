
    static void RaceCars(Car car1, Car car2)
    {
        int speed1 = car1.CalculateSpeed();
        int speed2 = car2.CalculateSpeed();

        if (speed1 > speed2)
        {
            Console.WriteLine($"Winner: {car1.Model}");
            Console.WriteLine($"Driver: {car1.Driver.Name}");
            Console.WriteLine($"Speed: {speed1}");
        }
        else if (speed2 > speed1)
        {
            Console.WriteLine($"Winner: {car2.Model}");
            Console.WriteLine($"Driver: {car2.Driver.Name}");
            Console.WriteLine($"Speed: {speed2}");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }

    static int GetValidChoice(int max, string message)
    {
        int choice;
        bool isValid;

        do
        {
            Console.WriteLine(message);
            isValid = int.TryParse(Console.ReadLine(), out choice);

        } while (!isValid || choice < 1 || choice > max);

        return choice;
    }

    
        Driver[] drivers = new Driver[]
        {
            new Driver("Bob", 5),
            new Driver("Greg", 7),
            new Driver("Jill", 6),
            new Driver("Anne", 8)
        };

        Car[] cars = new Car[]
        {
            new Car("Hyundai", 120),
            new Car("Mazda", 130),
            new Car("Ferrari", 200),
            new Car("Porsche", 180)
        };

        string again;

        do
        {
            // CAR 1
            Console.WriteLine("Choose car no.1:");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }

            int carChoice1 = GetValidChoice(4, "Enter number:");

            Console.WriteLine("Choose driver:");
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");
            }

            int driverChoice1 = GetValidChoice(4, "Enter number:");

            cars[carChoice1 - 1].Driver = drivers[driverChoice1 - 1];

            // CAR 2 (BONUS 1)
            Console.WriteLine("Choose car no.2:");

            for (int i = 0; i < cars.Length; i++)
            {
                if (i != carChoice1 - 1)
                {
                    Console.WriteLine($"{i + 1}. {cars[i].Model}");
                }
            }

            int carChoice2;
            do
            {
                carChoice2 = GetValidChoice(4, "Enter number:");
            }
            while (carChoice2 == carChoice1);

            Console.WriteLine("Choose driver:");
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");
            }

            int driverChoice2 = GetValidChoice(4, "Enter number:");

            cars[carChoice2 - 1].Driver = drivers[driverChoice2 - 1];

            // RACE
            RaceCars(cars[carChoice1 - 1], cars[carChoice2 - 1]);

            // BONUS 3
            Console.WriteLine("Race again? (y/n)");
            again = Console.ReadLine();

        } while (again.ToLower() == "y");
    
