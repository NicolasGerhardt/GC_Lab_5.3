using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_5._3
{
    public class UsedCar : Car
    {
        private double mileage;

        public double Mileage { get => mileage; set => mileage = value; }

        public UsedCar() : base()
        {
            mileage = 0.0;
        }
        public UsedCar(string make, string model, int year, double price, double mileage) : base(make, model, year, price)
        {
            this.mileage = mileage;
        }

        public override string ToString()
        {
            return base.ToString() + $" Mileage {mileage,8:0.0}";
        }

    }
}
