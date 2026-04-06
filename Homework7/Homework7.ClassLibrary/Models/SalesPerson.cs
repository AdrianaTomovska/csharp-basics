
namespace CompanyLibrary.Models;

public class SalesPerson : Employee
{
    private double SuccessSaleRevenue { get; set; }

    public SalesPerson(string firstName, string lastName, double initialRevenue = 0)
        : base(firstName, lastName, Role.Sales, 500) 
    {
        SuccessSaleRevenue = initialRevenue;
    }

    public void AddSuccessRevenue(double revenue)
    {
        if (revenue > 0)
            SuccessSaleRevenue += revenue;
    }

    public override double GetSalary()
    {
        double bonus = 0;

        if (SuccessSaleRevenue <= 2000)
            bonus = 500;
        else if (SuccessSaleRevenue <= 5000)
            bonus = 1000;
        else
            bonus = 1500;

        return base.GetSalary() + bonus;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Success Sale Revenue: {SuccessSaleRevenue}");
    }
}