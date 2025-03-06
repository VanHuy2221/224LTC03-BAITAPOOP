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