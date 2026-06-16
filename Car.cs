using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _year;
        private decimal _price;
        private string _color;
        public Car(string brand, string model, int year, decimal price, string color)
        {
            _brand = brand;
            _model = model;
            _year = year;
            _price = price;
            _color = color;
        }

        public string Brand
        {
            get { return _brand; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Brand cannot be empty");

                _brand = value;
            }
        }


        public string Model
        {
            get { return _model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Model cannot be empty");

                _model = value;
            }
        }


        public int Year
        {
            get { return _year; }
            set
            {
                if (value > DateTime.Now.Year)
                    throw new Exception("Invalid year");

                _year = value;
            }
        }


        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                    throw new Exception("Price must be positive");

                _price = value;
            }
        }


        public void ShowInfo()
        {
            Console.WriteLine($"{Brand} {Model} {Year} - {Price}$");
        }
    }
}

