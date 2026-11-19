namespace Employee_Salary_System
{
    internal class Employee
    {
        public required string Name { get; set; }

        private decimal _monthlySalary;

        public decimal MonthlySalary
        {
            get => _monthlySalary;
            set
            {
                if (value > 0)
                {
                    _monthlySalary = value;
                }
                else
                {
                    Console.WriteLine("Monthly salary must be greater than zero!");
                }
            }
        }

        public decimal AnnualSalary => MonthlySalary * 12;
    }
}