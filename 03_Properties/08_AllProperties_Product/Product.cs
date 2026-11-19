namespace all_Properties
{
    internal class Product
    {
        public string? Name { get; set; }

        private decimal _price;
        private int _quantity;

        public decimal Price
        {
            get => _price;
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
            }
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value >= 0)
                {
                    _quantity = value;
                }
            }
        }

        public decimal TotalPrice => _price * _quantity;
    }
}