namespace _03_ConstructorObjectCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            Console.WriteLine($"{S1.GetCount()}");

            Student S2 = new Student();
            Console.WriteLine($"{S2.GetCount()}");

            Student S3 = new Student();
            Console.WriteLine($"{S3.GetCount()}");



            //S2.GetCount();
            //S3.GetCount();

        }
    }
}
