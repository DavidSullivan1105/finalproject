using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenPlan.repository
{
    public class GreenPlanRepository
    {
        //DB
        public List<Car>  _carList = new List<Car>();



        //Create
        public void AddCarToList(Car car)
        {
            _carList.Add(car);
        }



        //Read



        //Update



        //Delete



        //Seed Data Method

        public void SeedCarData()
        {
            Car maverick = new Car ("Ford", "MaverickXLT", 2022, Color.Silver, 29, BodyStyle.PickupTruck, Transmission.automatic, 4, 36944, Drivetrain.AllWheelDrive, FuelType.Gasoline);
            Car prius = new Car ("Toyota", "Prius", 2008, Color.Black, 48, BodyStyle.Coupe, Transmission.automatic, 4, 8960.00, Drivetrain.FrontWheelDrive, FuelType.Hybrid);
            Car sorento = new Car ("Kia", "Sorento", 2022, Color.White, 33, BodyStyle.SUV, Transmission.automatic, 6, 46990.00, Drivetrain.AllWheelDrive, FuelType.Hybrid);
            Car accord = new Car ("Honda", "Accord", 2021, Color.Black, 44, BodyStyle.Sedan, Transmission.automatic, 4, 37996.00, Drivetrain.FrontWheelDrive, FuelType.Hybrid);
            Car enclave = new Car ("Buick", "Enclave", 2011, Color.Black, 22, BodyStyle.SUV, Transmission.automatic, 6, 11295.00, Drivetrain.AllWheelDrive, FuelType.Gasoline);
            Car hhr = new Car ("Chevrolet", "HHR", 2007, Color.Red, 22, BodyStyle.Hatchback, Transmission.manual, 4, 7844.00, Drivetrain.FrontWheelDrive, FuelType.Gasoline);
            Car modelx = new Car ("Tesla", "ModelX", 2018, Color.White, 95, BodyStyle.Sedan, Transmission.automatic, 0, 91250.00, Drivetrain.AllWheelDrive, FuelType.Electric);
            Car volt = new Car ("Chevrolet", "Volt", 2014, Color.Black, 97, BodyStyle.Sedan, Transmission.automatic, 0, 17350.00, Drivetrain.FrontWheelDrive, FuelType.Electric);

            Car[] carArr = {maverick, prius, sorento, accord, enclave, hhr, modelx, volt};

            foreach(Car car in carArr)
            {
                AddCarToList(car);
            }

        }
    }
}