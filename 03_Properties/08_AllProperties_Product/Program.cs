namespace all_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product P1 = new Product();
            P1.Name = "Snacks";
            P1.Quantity = 10;
            P1.Price = 5;

            Console.WriteLine($"Total Price: {P1.TotalPrice}");
        }
    }
}