namespace Auto_Properties
{
    internal class Product
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Product Name: {Name}\nProduct Price: {Price}\nQuantity Available: {Quantity}");
        }
    }
}