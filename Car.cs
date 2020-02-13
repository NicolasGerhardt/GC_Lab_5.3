using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_5._3
{
    public class Car
    {
        private static int carID;
        private static int count = 0;
        private string make;
        private string model;
        private int year;
        private double price;

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }
        public int CarID { get => carID; }

        public Car()
        {
            carID = count;
            count++;
            make = "Ford";
            model = "Fusion";
            year = 2020;
            price = 0.0;
        }

        public Car(string make, string model, int year, double price)
        {
            carID = count;
            count++;
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public override string ToString()
        {
            return $"({CarID}){Make} {Model} {Year} {Price.ToString("C")}";
        }
    }
}
