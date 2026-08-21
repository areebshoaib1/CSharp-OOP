
/*Create a Student class with:

name
rollNo
marks

A function to calculate and display the student's grade based on their marks.
Create multiple Student objects and call the grade-calculation function for each student.

********** Author: Muhammad Areeb Shoaib **********
*/
using System;
namespace _01_StudentGradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student("ABC", "PE-24-013", 80);
            Student S2 = new Student("XYZ", "M-24-217", 90);
            Student S3 = new Student("XYZ", "PE-24-199", 47);

            S1.CalculateGrade();
            S2.CalculateGrade();
            S3.CalculateGrade();
        }
    }
}
