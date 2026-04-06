namespace Homework6.ATM.Models;

public class Customer
{
    public string FullName { get; set; }
    public string CardNumber { get; set; }

    private int Pin;
    private double Balance;

    public Customer(string fullName, string cardNumber, int pin, double balance)
    {
        FullName = fullName;
        CardNumber = cardNumber;
        Pin = pin;
        Balance = balance;
    }

    public bool CheckPin(int pin)
    {
        return Pin == pin;
    }

    public double GetBalance()
    {
        return Balance;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public bool Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }
}