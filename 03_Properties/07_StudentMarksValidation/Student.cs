namespace Student_Marks_Validation
{
    internal class Student
    {
        public string? Name { get; set; }

        // Nullable: null means "not assigned yet"
        private double? _marks;

        public double? Marks
        {
            get => _marks;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _marks = value;
                }
                else if (value < 0)
                {
                    Console.WriteLine("Marks can't be negative!");
                }
                else if (value > 100)
                {
                    Console.WriteLine("Marks can't be greater than 100!");
                }
            }
        }
    }
}