public class Entry
{
    public static void Main(string[] args)
    {
        Console.WriteLine("+----------------------+");
        Console.WriteLine("| Masv: 23115053122221 |");
        Console.WriteLine("| Hoten: Pham Van Huy  |");
        Console.WriteLine("+----------------------+");

        IEmployee employee1 = new PartTimeEmployee("Nguyen Van Vuong", 50000, 7);
        Console.WriteLine("Name: " + employee1.GetName());
        Console.WriteLine("Salary per day: " + employee1.CalculateSalary());

        IEmployee employee2 = new FullTimeEmployee("Ho Ngoc Linh", 75000);
        Console.WriteLine("Name: " + employee2.GetName());
        Console.WriteLine("Salary per day: " + employee2.CalculateSalary());
    }
}