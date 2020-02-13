using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_5._3
{
    public class CarLot
    {
        private Car[,] lot;
        private int width;
        private int length;

        public Car[,] Lot { get => lot; }
        public int Width { get => width; }
        public int Length { get => length; }

        public CarLot(int width, int length)
        {
            this.width = width;
            this.length = length;

            lot = new Car[Width, Length];
        }

        public bool AddCar(Car car)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < length; y++)
                {
                    if (lot[x,y] == null)
                    {
                        lot[x, y] = car;
                        return true;
                    }
                }
            }

            return false;
        }

       public List<Car> ListCars()
        {
            var outputList = new List<Car>();
            foreach (Car car in lot)
            {
                if (car != null)
                {
                    outputList.Add(car);
                }
            }

            return outputList;

        }

        public bool RemoveCar(Car car)
        {
            for (int X = 0; X < width; X++)
            {
                for (int Y = 0; Y < length; Y++)
                {
                    if (car == lot[X,Y])
                    {
                        lot[X, Y] = null;
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
