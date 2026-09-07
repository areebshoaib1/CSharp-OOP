using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace _04_ConstructorOverloading
{
    internal class ConstructorOverloading
    {
        private readonly string name;
        private readonly string id;
        private readonly decimal salary;

        public ConstructorOverloading()
        {
            name = " ";
            id = " ";
            salary = 0m;
            Console.WriteLine($" Default Constructor called!");

        }
        public ConstructorOverloading(string ID)
        {
            id = ID;
            name = " ";
            Console.WriteLine($" Constructor with one parameter called!");

        }
        public ConstructorOverloading(string ID, string Name, int Salary)
        {
            id = ID;
            name = Name;
            salary = Salary;
            Console.WriteLine($" Constructor with three parameter called!");

        }
        public ConstructorOverloading(string Name, int Salary, string ID)
        {
            id = ID;
            name = Name;
            salary = Salary;
            Console.WriteLine($" Constructor with three parameter  but different sequence called!");

        }






    }
}
