using System;
using System.Collections.Generic;

namespace GC_Lab_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //initalize Lots
            CarLot mainLot = new CarLot(10, 10);
            mainLot.AddCar(new Car());
            mainLot.AddCar(new Car("Chevy","Impala", 2019, 20_000));
            mainLot.AddCar(new Car("Buick", "Regal", 2020, 50_000));
            mainLot.AddCar(new UsedCar("Ford","Focus", 2013, 1_000, 80_000));
            mainLot.AddCar(new UsedCar("Nissan", "Maxima", 2005, 500, 180_000));
            mainLot.AddCar(new UsedCar("Cadillac", "ATS", 2016, 6_000, 50_000));

            // Hello and welcome persons thing
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Welcome to Brea's New Car Emporum and Nic's Pre-owned Vehicle Junk Heap *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            // Show list of all the cars
            showListofAllCarsOnLot(mainLot);

            // Ask what they want to do Add, List, or buy a car.
            int operation = GetOperationChoiceFromUser();
            // Got into choosen function
            // End program


        }

        private static int GetOperationChoiceFromUser()
        {
            // Show them what they can do
            Console.WriteLine("Do you want to Sell, Buy or See what we have in stock?");
            // Ask what they want to do Add, List, or buy a car
            Console.WriteLine("1: Sell");
            Console.WriteLine("2: Buy");
            Console.WriteLine("3: See Stock");
            Console.Write("> ");
            // Get int from user
            int choice = int.Parse(Console.ReadLine());
            // return int
            return choice;
        }

        private static void showListofAllCarsOnLot(CarLot lot)
        {
            List<Car> carList = lot.ListCars();

            Console.WriteLine("Here is our current inventory");
            Console.WriteLine("*********************************************************");

            foreach (Car car in carList)
            {
                if (car is UsedCar)
                {
                    Console.Write("|Used: ");
                }
                else
                {
                    Console.Write("| New: ");
                }
                Console.WriteLine(car);
                
            }
            Console.WriteLine();


        }
    }
}
