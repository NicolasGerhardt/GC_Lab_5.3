using System;
using System.Collections.Generic;

namespace GC_Lab_5._3
{
    class Program
    {
        public static CarLot mainLot;
        static void Main(string[] args)
        {
            //initalize Lots
            mainLot = new CarLot(10, 10);
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
            bool done = false;
            do
            {


                // Ask what they want to do Add, List, or buy a car.
                int operation = GetOperationChoiceFromUser();
                // Got into choosen function
                switch (operation)
                {
                    case 1:
                        mainLot.AddCar(GetCarInfoFromUser());
                        break;
                    case 2:
                        BuyCarOffLot();
                        break;
                    case 3:
                        showListofAllCarsOnLot(mainLot);
                        break;
                    case 4:
                        done = true;
                        break;
                }
            } while (!done);

            Console.WriteLine("Have a great day!");


        }

        private static void BuyCarOffLot()
        {
            // Show list of cars
            showListofAllCarsOnLot(mainLot);
            // Get ID from user
            int carID = int.Parse(GetStringFromUser("Enter Car ID you are interested in: "));
            // Remove Car ID from Lot
            mainLot.RemoveCar(carID);
            // Thank them for their business


        }

        private static Car GetCarInfoFromUser()
        {
            Console.WriteLine("What type of car are you selling?");
            string make = GetStringFromUser("   Make: ");
            string model = GetStringFromUser("  Model: ");
            int year = int.Parse(GetStringFromUser("   Year: ")); //TODO: Validation
            double mileage = double.Parse(GetStringFromUser("Mileage: ")); //TODO: Validation
            double price = double.Parse(GetStringFromUser("  Price: ")); //TODO: Validation

            return new UsedCar(make, model, year, price, mileage);
        }

        private static string GetStringFromUser(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        private static int GetOperationChoiceFromUser()
        {
            // Show them what they can do
            Console.WriteLine("Do you want to Sell, Buy or See what we have in stock?");
            // Ask what they want to do Add, List, or buy a car
            Console.WriteLine("1: Sell");
            Console.WriteLine("2: Buy");
            Console.WriteLine("3: See Stock");
            Console.WriteLine("4: Leave");
            Console.Write("> ");
            // Get int from user
            int choice = int.Parse(Console.ReadLine()); //TODO: Validation 
            // return int
            return choice;
        }

        private static void showListofAllCarsOnLot(CarLot lot)
        {
            List<Car> carList = lot.ListCars();

            Console.WriteLine("Here is our current inventory");
            Console.WriteLine("*********************************************************");
            Console.WriteLine($"{"ID",-3} | {"Type",-3} | {"Year",-4} | {"Make",-12} | {"Model",-12} | {"Price",10} |");

            foreach (Car car in carList)
            {
                Console.Write($"{car.CarID,-3} ");
                if (car is UsedCar)
                {
                    Console.Write("| Used ");
                }
                else
                {
                    Console.Write("| New  ");
                }
                Console.WriteLine(car);
                
            }
            Console.WriteLine();


        }
    }
}
