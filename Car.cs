using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOpgave1
{
    public class Car
    {
        private int _id;
        private string _model;
        private double _price;
        private string _licensePlate;

        public Car(int id, string model, double price, string licensePlate)
        {
            Id = id;
            Model = model;
            Price = price;
            LicensePlate = licensePlate;
        }

        public int Id
        {
            get => _id;
            set
            {
                if (value < 1) { throw new ArgumentOutOfRangeException(); }
                _id = value;
            }
        }

        public string Model
        {
            get => _model;
            set
            {
                if (value == null) throw new ArgumentNullException();
                if (value == "") throw new ArgumentException(message: "emtpy input");
                if (value.Length < 4) throw new ArgumentOutOfRangeException();
                _model = value;
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value < 1) { throw new ArgumentOutOfRangeException(); }
                _price = value;
            }
        }

        public string LicensePlate
        {
            get => _licensePlate;
            set
            {
                if (value.Length <= 2) { throw new ArgumentOutOfRangeException(); }
                if (value.Length > 7) { throw new ArgumentOutOfRangeException(); }
                _licensePlate = value;
            }
        }
    }
}
