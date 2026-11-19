namespace Auto_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product P1 = new Product();
            P1.Name = "Snacks";
            P1.Price = 50;
            P1.Quantity = 10;

            P1.DisplayDetails();
        }
    }
}