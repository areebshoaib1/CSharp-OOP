namespace _04_CarStartStop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car C1 = new Car(" Mercedes-Benz", 300);
            Car C2 = new Car(" Lamborghini cian", 350);

            C1.Start();
            C1.Stop();
            C1.DisplayInfo();
            Console.WriteLine();
            C2.Start();
            C2.Stop();
            C2.DisplayInfo();


        }
    }
}
