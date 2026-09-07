using System;
using System.Collections.Generic;
using System.Text;

namespace _06_DefaultParameterizedConstructors
{
    internal class Product
    {
        private readonly string Name;
        private readonly decimal Price;

        public Product()
        {
            Name = "Unknown";
            Price = 0;
            Console.WriteLine($"Default Constructor:\n Name: {Name}\n Price: {Price}");
        }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
            Console.WriteLine($"Parameterized Constructor:\n Name: {Name}\n Price: {Price}");
        }

    }
}
