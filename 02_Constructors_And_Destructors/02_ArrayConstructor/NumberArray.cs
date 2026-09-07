using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ArrayConstructor
{
    internal class NumberArray
    {
        private int[] arr;
        private int Length;
        public NumberArray(int length)
        {
            Length = length;

            arr = new int[length];
            for (int i = 1; i <= length; i++)
            {
                arr[i-1] = i;
            }

        }

        public void Display()
        {

            Console.Write("[");
            for (int i = 0; i < Length; i++)
            {
                Console.Write($" {arr[i]} ");
            }
            Console.Write("]");

        }


    }
}