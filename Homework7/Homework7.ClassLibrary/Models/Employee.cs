using System;

namespace CompanyLibrary.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public Employee(string firstName, string lastName, Role role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Employee: {FirstName} {LastName} | Role: {Role}");
        }
    }
}