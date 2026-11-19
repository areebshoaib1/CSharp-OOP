namespace Computed_Properties
{
    internal class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        // Computed on every read,never stored
        public double Area => Length * Width;
        public double Perimeter => 2 * (Length + Width);
    }
}