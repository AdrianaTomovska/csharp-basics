namespace CompanyLibrary.Models;

public class Manager : Employee
{
    private double Bonus { get; set; }

    public Manager(string firstName, string lastName, double initialBonus = 0)
        : base(firstName, lastName, Role.Manager, 0) 
    {
        Bonus = initialBonus;
    }

    public void AddBonus(double amount)
    {
        if (amount > 0)
            Bonus += amount;
    }

    public override double GetSalary()
    {
        return base.GetSalary() + Bonus;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Bonus: {Bonus}");
    }
}