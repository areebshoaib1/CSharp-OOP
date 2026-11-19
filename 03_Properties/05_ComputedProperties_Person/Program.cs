namespace Computed_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            P1.FirstName = "Muhammad Areeb";
            P1.LastName = "Shoaib";

            Console.WriteLine($"Full Name: {P1.FullName}");
        }
    }
}