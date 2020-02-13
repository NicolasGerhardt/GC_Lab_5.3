# Lab 5.3: Used Car Lot
## Task
Hold information about Car inventory using a collection of Car objects, including a UsedCar subclass.

## What will the application do?
* Display a set of at least 6 cars (at least 3 new and 3 used) along with Add and Quit options
* Let the user select one of the cars.
* Ask if they want to buy the car. Remove it from the list if they do.
* If they want to add a car, get the details, instantiate a new car of the appropriate type, and add it to your data collection.
* Keep looping until they choose to quit.

## Build Specifications
* Work with your assigned pair for this lab.
* Create a class named Car (5 points) to store the data about this car. This class should contain:
	* Data members for car details
		* A String for the make
		* A String for the model
		* An int for the year
		* A double for the price
	* A no-arguments constructor that sets data members to default values (blanks or your choice)
	* A constructor with four arguments matching the order above
	* Properties for all data members
	* An override the ToString() method returning a formatted string with the car details.
* Discuss with your partner how a CarLot class (5 points) could best store information. In what cases would each of these make more sense?
	* A two-dimensional array of Cars
	* A List of Cars
	* A Dictionary <?, Car>
	* Any other option?
	* However you store information inside the class, this should include methods to
		* Add a car
		* List all cars to the console
		* Remove a car
* Write a CarLotApp class which instantiates and puts cars in your CarLot class. It should invoke CarLot methods to let a user:
	* List all cars.
	* Buy a car, which removes it from the inventory.
	* Add a car.
	
## Extended Challenge
* Think about other methods which might be useful for your CarLot. Implement them and modify your app to take advantage of them.
* Modify or create a class named Validator with static methods to validate the data in this application.
* Create an Admin mode which lets the user edit, delete, or replace cars. Move the Add a car feature here.
* Provide search features:
	* View all cars of an entered make.
	* View all cars of an entered year.
	* View all cars of an entered price or less.
	* View only used cars or view only new cars.