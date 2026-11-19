namespace Computed_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle R1 = new Rectangle();
            R1.Length = 15;
            R1.Width = 5;

            Console.WriteLine($"Area: {R1.Area}");
            Console.WriteLine($"Perimeter: {R1.Perimeter}");
        }
    }
}