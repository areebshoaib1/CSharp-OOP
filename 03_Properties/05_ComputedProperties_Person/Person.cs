namespace Computed_Properties
{
    internal class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}