using System;
using System.Collections.Generic;
using System.Text;

namespace _05_ConstructorDestructorOrder
{
    internal class Parent

    {
        public Parent()
        {
            Console.WriteLine("Parent Constructor called!");
        }
        ~Parent()
        {
            Console.WriteLine("Parent Destructor called!");
        }
    }

    internal class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Child Constructor called!");
        }

        ~Child()
        {
            Console.WriteLine("Child Destructor called!");
        }


    }
}
