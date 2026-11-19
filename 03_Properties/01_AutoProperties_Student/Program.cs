namespace Auto_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.Name = "Areeb";
            S1.RollNo = "BSE-23F-063";
            S1.Marks = 83;

            Console.WriteLine($"Name: {S1.Name}\nRoll Number: {S1.RollNo}\nMarks: {S1.Marks}");
        }
    }
}