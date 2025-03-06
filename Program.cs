using System;

public interface IEmployee
{
    double CalculateSalary();
    string GetName();
}

public abstract class Employee : IEmployee
{
    private string name;
    private int paymentPerHour;

    public Employee(string name, int paymentPerHour)
    {
        this.name = name;
        this.paymentPerHour = paymentPerHour;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public int GetPaymentPerHour()
    {
        return paymentPerHour;
    }

    public void SetPaymentPerHour(int paymentPerHour)
    {
        this.paymentPerHour = paymentPerHour;
    }

    public abstract double CalculateSalary();
}

public class PartTimeEmployee : Employee
{
    private int workingHours;

    public PartTimeEmployee(string name, int paymentPerHour, int workingHours) 
        : base(name, paymentPerHour)
    {
        this.workingHours = workingHours;
    }

    public override double CalculateSalary()
    {
        return workingHours * GetPaymentPerHour();
    }
}

public class FullTimeEmployee : Employee
{
    public FullTimeEmployee(string name, int paymentPerHour) 
        : base(name, paymentPerHour)
    {
    }

    public override double CalculateSalary()
    {
        return 8 * GetPaymentPerHour();
    }
}

public class Entry
{
    public static void Main(string[] args)
    {
        IEmployee employee1 = new PartTimeEmployee("Trung", 45000, 7);
        Console.WriteLine("Name: " + employee1.GetName());
        Console.WriteLine("Salary per day: " + employee1.CalculateSalary());

        IEmployee employee2 = new FullTimeEmployee("Linh", 65000);
        Console.WriteLine("Name: " + employee2.GetName());
        Console.WriteLine("Salary per day: " + employee2.CalculateSalary());
    }
}
