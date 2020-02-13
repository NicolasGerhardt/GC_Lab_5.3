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

    }
}
