namespace Student_Marks_Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.Name = "M. Areeb Shoaib";
            Console.WriteLine("Enter Marks: ");
            string? input = Console.ReadLine();

            if(double.TryParse(input, out double parsedmarks))
            {
                S1.Marks = parsedmarks;
            }

            if (S1.Marks == null)
            {
                Console.WriteLine("Marks: Not assigned yet!");
            }
            else
            {
                Console.WriteLine($"Marks: {S1.Marks}");
            }
        }
    }
}