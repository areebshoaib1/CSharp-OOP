namespace Controlled_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee();
            E1.Name = "Areeb";
            E1.Salary = -100000;

            Console.WriteLine($"Salary: {E1.Salary}");
        }
    }
}