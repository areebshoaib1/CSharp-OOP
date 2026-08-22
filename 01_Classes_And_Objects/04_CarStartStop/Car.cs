using System;
using System.Collections.Generic;
using System.Text;

namespace _04_CarStartStop
{
    internal class Car
    {
        private readonly string _brandName;
        private readonly int _topSpeed;
        public Car(string brandName, int topSpeed)
        {
            _brandName = brandName;
            _topSpeed = topSpeed;


        }
        public void Start()
        {
            Console.WriteLine($"{_brandName} Started!");
        }
        public void Stop()
        {
            Console.WriteLine($"{_brandName} Stopped!");
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Details:\n Brand Name: {_brandName}\n Top Speed: {_topSpeed}km/h");
        }
    }


}

