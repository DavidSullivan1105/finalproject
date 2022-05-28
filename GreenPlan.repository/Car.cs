using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenPlan.repository
{
    public class Car
    {
        
        public string Make { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }

        public Color ColorOptions { get; set; }

        public decimal MPG { get; set; }

        public BodyStyle BodyStyleOptions { get; set; }

        public Transmission TransmissionOptions { get; set; }

        public int Cylinders { get; set; }

        public decimal Price { get; set; }

        public Drivetrain DrivetrainOptions { get; set; }

        public FuelType FuelTypeOptions { get; set; }

        public Car (string make, string model, int year, Color color, decimal mpg, BodyStyle bodyStyle, Transmission transmission, int cylinders, decimal price, Drivetrain drivetrain, FuelType fueltype )
        {
            Make = make;
            Model = model;
            Year = year;
            ColorOptions = color;
            MPG = mpg;
            BodyStyleOptions = bodyStyle;
            TransmissionOptions = transmission;
            Cylinders = cylinders;
            Price = price;
            DrivetrainOptions = drivetrain;
            FuelTypeOptions = fueltype;

        }

        public Car (){}





    } 
    public enum Color { Red, Blue, Black, White, Yellow, Green, Silver, Tan} 
    public enum BodyStyle { CargoVan, Convertible, Coupe, Hatchback, Minivan, PassengerVan, PickupTruck, SUV, Sedan, Wagon}
    public enum Transmission { automatic, manual } 
    public enum Drivetrain { AllWheelDrive, FourWheelDrive, FrontWheelDrive, RearWheelDrive }
    public enum FuelType { Electric, Gasoline, Hybrid }

}