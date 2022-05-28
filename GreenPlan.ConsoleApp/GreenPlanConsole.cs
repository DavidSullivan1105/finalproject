using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenPlan.repository;
namespace GreenPlan.ConsoleApp
{
    public class GreenPlanConsole
    {
        public void PrintMainMenu()
        {
            Console.WriteLine("Welcome to the Komodo Insurance Green Plan Manager! \n" +
                            "The best way to manage vehicle data for the green future! \n" +
                            "Please select a number from the following options: \n" +
                            "1. View Gasoline Vehicles \n" +
                            "2. View Electric Vehicles \n" +
                            "3. View Hybrid Vehicles \n" +
                            "4. Create New Vehicles \n" +
                            "5. Update Existing Vehicles \n" +
                            "6. Delete Vehicles \n" +
                            "7. Exit");
        }

        public string GetUserInput()
        {
            return Console.ReadLine();
        }

        public int GetUserInputInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public decimal GetUserDecimal()
        {
            return Convert.ToDecimal(Console.ReadLine());
        }

        public void PrintCars(Car car)
        {
            Console.WriteLine($"Make: {car.Make} \n" +
                            $"Model: {car.Model} \n" +
                            $"Year: {car.Year} \n" +
                            $"Color: {car.ColorOptions} \n" +
                            $"MPG: {car.MPG} \n" +
                            $"Body Style: {car.BodyStyleOptions} \n" +
                            $"Transmission: {car.TransmissionOptions} \n" +
                            $"Cylinders: {car.Cylinders} \n" +
                            $"Price: {car.Price} \n" +
                            $"Drivetrain: {car.DrivetrainOptions} \n" +
                            $"Fuel Type: {car.FuelTypeOptions} \n1");
        }

        public void PrintAllCars(List<Car> cars)
        {
            foreach(Car x in cars)
            {
                PrintCars(x);
            }
        }

        public void EnterAMake()
        {
            Console.WriteLine("Please enter a make:");
        }

        public void EnterAModel()
        {
            Console.WriteLine("Please enter a model:");
        }

        public void EnterAYear()
        {
            Console.WriteLine("Please enter a year:");
        }

        public void EnterAColor()
        {
            Console.WriteLine("Please choose a color: \n" +
                            "1. Red \n" +
                            "2. Blue \n" +
                            "3. Black \n" +
                            "4. White \n" +
                            "5. Yellow \n" +
                            "6. Green \n" +
                            "7. Silver \n" +
                            "8. Tan \n");
        }

        public void EnterMPG()
        {
            Console.WriteLine("Please enter a MPG:");
        }

        public void EnterABodyStyle()
        {
            Console.WriteLine("Please enter a body style: \n" +
                            "1. Cargo Van \n" +
                            "2. Convertible \n" +
                            "3. Coupe \n" +
                            "4. Hatchback \n" +
                            "5. Minivan \n" +
                            "6. Passenger Van \n" +
                            "7. Pickup Truck \n" +
                            "8. SUV \n" +
                            "9. Sedan \n" +
                            "10. Wagon \n");
        }

        public void EnterTransmissionType()
        {
            Console.WriteLine("Choose a transmission type: \n" +
                            "1. Automatic \n" +
                            "2. Manual");
        }

        public void HowManyCylinders()
        {
            Console.WriteLine("How many cylinders?");
        }

        public void EnterAPrice()
        {
            Console.WriteLine("What is the price?");
        }

        public void DrivetrainType()
        {
            Console.WriteLine("Choose a drivetrain type: \n" +
                            "1. All Wheel Drive \n" +
                            "2. 4 Wheel Drive \n" +
                            "3. Front Wheel Drive \n" +
                            "4. Rear Wheel Drive");
        }

        public void FuelType()
        {
            Console.WriteLine("Choose a fuel type: \n" +
                            "1. Electric \n" +
                            "2. Gasoline \n" +
                            "3. Hybrid");
        }

        public void EnterMakeToDelete()
        {
            Console.Write("Enter a make to delete: ");
        }

        public void EnterModelToDelete()
        {
            Console.Write("Enter a model to delete: ");
        }

        public void EnterYearToDelete()
        {
            Console.Write("Enter a year to delete: ");
        }

        public void EnterColorToDelete()
        {
            Console.WriteLine("Choose number you wish to delete: \n" +
                            "1. Red \n" +
                            "2. Blue \n" +
                            "3. Black \n" +
                            "4. White \n" +
                            "5. Yellow \n" +
                            "6. Green \n" +
                            "7. Sliver \n" +
                            "8. Tan ");
        } 

        public void EnterMPGToDelete()
        {
            Console.Write("Enter MPG to delete: ");
        }

        public void EnterBodyStyleToDelete()
        {
            Console.WriteLine("Choose a body style to delete: \n" +
                            "1. Cargo Van \n" +
                            "2. Convertible \n" +
                            "3. Coupe \n" +
                            "4. Hatchback \n" +
                            "5. Minivan \n" +
                            "6. Passenger Van \n" +
                            "7. Pickup Truck \n" +
                            "8. SUV \n" +
                            "9. Sedan \n" +
                            "10. Wagon");
        }

        public void EnterTransmissionToDelete()
        {
            Console.WriteLine("Choose a transmission style to delete: \n" +
                            "1.Automatic \n" +
                            "2. Manual ");
        }

        public void EnterCylindersToDelete()
        {
            Console.Write("Enter cylinders to delete: ");
        }

        public void EnterPriceToDelete()
        {
            Console.Write("Enter price to delete: ");
        }

        public void EnterDrivetrainToDelete()
        {
            Console.WriteLine("Choose a drivetrain to delete: \n" +
                            "1. All Wheel Drive \n" +
                            "2. 4 Wheel Drive \n" +
                            "3. Front Wheel Drive \n" +
                            "4. Rear Wheel Drive ");
        }

        public void EnterFuelTypeToDelete()
        {
            Console.WriteLine("Choose a fueltype to delete: \n" +
                            "1. Electric \n" +
                            "2. Gasoline \n" +
                            "3. Hybrid");
        }
        
        public void CarSuccessfullyDeleted()
        {
            Console.WriteLine("Car successfully deleted!");
        }

        public void SomethingWentWrong()
        {
            Console.WriteLine("Uh oh...something went wrong");
        }

        public void CarNotFound()
        {
            Console.WriteLine("Car not found");
        }

        public void PressAnyKeyToContinue()
        {
            Console.Write("Press Any Key to Continue...");

            
        }


        public void ExitMessage()
        {
            Console.WriteLine("Have A Nice Day! \n");
            bool isRunning = false;
        }
    }
} 