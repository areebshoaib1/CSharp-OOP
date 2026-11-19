namespace Controlled_Properties
{
    internal class Employee
    {
        public string? Name { get; set; }

        private decimal _salary;

        public decimal Salary
        {
            get => _salary;
            set
            {
                if (value >= 0)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Salary can't be negative!");
                }
            }
        }
    }
}