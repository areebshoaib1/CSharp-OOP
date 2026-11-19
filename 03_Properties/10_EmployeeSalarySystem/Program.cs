namespace Employee_Salary_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee
            {
                Name = "Areeb"
            };

            Console.Write("Enter Salary: ");
            string? input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal result))
            {
                E1.MonthlySalary= result;
            }



            Console.WriteLine($"Annual Salary: {E1.AnnualSalary}");
        }
    }
}