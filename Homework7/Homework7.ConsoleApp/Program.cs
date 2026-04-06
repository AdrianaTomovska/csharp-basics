using CompanyLibrary.Models;


SalesPerson alice = new SalesPerson("Alice", "Smith");
alice.AddSuccessRevenue(1500); 
alice.PrintInfo();
Console.WriteLine($"Salary with bonus: {alice.GetSalary()}\n");


alice.AddSuccessRevenue(4000); 
alice.PrintInfo();
Console.WriteLine($"Salary with bonus: {alice.GetSalary()}\n");


Manager bob = new Manager("Bob", "Johnson", 2000); 
bob.PrintInfo();
Console.WriteLine($"Salary with bonus: {bob.GetSalary()}\n");


bob.AddBonus(1000);
bob.PrintInfo();
Console.WriteLine($"Salary with bonus: {bob.GetSalary()}\n");
   
