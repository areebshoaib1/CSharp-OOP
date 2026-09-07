namespace _04_ConstructorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstructorOverloading CO1 = new ConstructorOverloading();

            ConstructorOverloading CO2 = new ConstructorOverloading("201");

            ConstructorOverloading CO3 = new ConstructorOverloading("201", "ABC", 45000);

            ConstructorOverloading CO4 = new ConstructorOverloading("201", 45000, "ABC");
        }
    }
}
