
using System;

namespace _01_StudentGradeCalculator
{
    internal class Student

    {
        private readonly string _name;
        private readonly string _rollnumber;
        private readonly int _marks;

        public Student(string Name, string RollNumber, int Marks)
        {
            _name = Name;
            _rollnumber = RollNumber;
            _marks = Marks;


        }

        public void CalculateGrade()
        {

            switch (_marks)
            {
                case >= 90:
                    Console.WriteLine($"Student Name:{_name}\nRoll Number: {_rollnumber}\nGrade=A\n");
                    break;
                case >= 80:
                    Console.WriteLine($"Student Name:{_name}\nRoll Number: {_rollnumber}\nGrade=B\n");
                    break;
                case >= 70:
                    Console.WriteLine($"Student Name:{_name}\nRoll Number: {_rollnumber}\nGrade=C\n");
                    break;
                case >= 60:
                    Console.WriteLine($"Student Name:{_name}\nRoll Number: {_rollnumber}\nGrade=D\n");
                    break;
                case >= 50:
                    Console.WriteLine($"Student Name:{_name}\nRoll Number: {_rollnumber}\nGrade=E\n");
                    break;
                default:
                    Console.WriteLine($"Student Name:{_name}\nRoll Number: {_rollnumber}\nFail\n");
                    break;


            }
        }



    }
}
