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