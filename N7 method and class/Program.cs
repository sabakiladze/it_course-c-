using System;

namespace ProductManagement
{
    public class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private int _quantity;
        private double _discountPercent;
        private double _rating;

        public int Id
        {
            get { return _id; }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    _name = "Unknown";
                }
            }
        }

        public string Description { get; set; }

        public double Price
        {
            get { return _price; }
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
            get { return _quantity; }
            set
            {
                if (value >= 0)
                {
                    _quantity = value;
                }
            }
        }

        public string Brand { get; set; }
        public string Category { get; set; }

        public double Rating
        {
            get { return _rating; }
            set
            {
                if (value >= 0 && value <= 5)
                {
                    _rating = value;
                }
            }
        }

        public bool IsAvailable => Quantity > 0;

        public double DiscountPercent
        {
            get { return _discountPercent; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _discountPercent = value;
                }
            }
        }

        public Product(int id, string name, string description, double price, int quantity, string brand, string category, double rating, double discountPercent)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            Brand = brand;
            Category = category;
            Rating = rating;
            DiscountPercent = discountPercent;
        }

        public double GetFinalPrice()
        {
            return Price - (Price * (DiscountPercent / 100));
        }

        public void IncreaseStock(int amount)
        {
            if (amount > 0)
            {
                Quantity += amount;
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Product: {Name} | Price: {Price} | Discount: {DiscountPercent}% | Final Price: {GetFinalPrice()} | Available: {IsAvailable}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Laptop", "Gaming Laptop", 2500, 5, "Asus", "Electronics", 4.8, 10);
            product1.PrintDetails();

            product1.IncreaseStock(5);
            product1.PrintDetails();

            Console.ReadLine();
        }
    }
}