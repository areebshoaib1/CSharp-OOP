namespace _05_ConstructorDestructorOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateObject();


            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.ReadLine();
        }


        static void CreateObject()
        {
            Child C1 = new Child();
        }
    }
}
