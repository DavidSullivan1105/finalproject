using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenPlan.repository
{
    public class GreenPlanRepository
    {
        //DB
        public List<Car> _gasolineCarList = new List<Car>();
        public List<Car> _hybridCarList = new List<Car>();
        public List<Car> _electricCarList = new List<Car>(); 
        public List<Car> _masterList = new List<Car>();


        //Create
        public void AddGasolineCarToList(Car car)
        {
            _gasolineCarList.Add(car);
        }

        public void AddHybridCarToList(Car car)
        {
            _hybridCarList.Add(car);
        }

        public void AddElectricCarToList(Car car)
        {
            _electricCarList.Add(car);
        }




        //Read
        public List<Car> GetGasolineVehicles()
        {
            return _gasolineCarList;
        }

        public List<Car> GetHybridVehicles()
        {
            return _hybridCarList;
        }

        public List<Car> GetElectricVehicles()
        {
            return _electricCarList;
        }

        public List<Car> GetMasterList()
        {
            List<Car> _masterList = new List<Car>();
            _masterList = _gasolineCarList.Concat(_electricCarList).Concat(_hybridCarList).ToList();
            return _masterList;
        }

        public Car GetCarByMakeModelYear(string make, string model, int year)
        {
            foreach(Car x in _masterList)
            {
                if(make == x.Make && model == x.Model && year == x.Year)
                {
                    return x;
                }
            }
                return null;
        }





        //Update



        //Delete
        public bool DeleteCarFromMasterList(Car car)
        {
            int totalCarsInMasterList = _masterList.Count();
            
            _masterList.Remove(car);

            if(totalCarsInMasterList == _masterList.Count())
            {
                return false;
            }

            return true;
        }



        //Seed Data Method

        public void SeedCarData()
        {
            Car maverick = new Car ("Ford", "MaverickXLT", 2022, Color.Silver, 29m, BodyStyle.PickupTruck, Transmission.automatic, 4, 36944.00m, Drivetrain.AllWheelDrive, FuelType.Gasoline);
            Car prius = new Car ("Toyota", "Prius", 2008, Color.Black, 48m, BodyStyle.Coupe, Transmission.automatic, 4, 8960.00m, Drivetrain.FrontWheelDrive, FuelType.Hybrid);
            Car sorento = new Car ("Kia", "Sorento", 2022, Color.White, 33m, BodyStyle.SUV, Transmission.automatic, 6, 46990.00m, Drivetrain.AllWheelDrive, FuelType.Hybrid);
            Car accord = new Car ("Honda", "Accord", 2021, Color.Black, 44m, BodyStyle.Sedan, Transmission.automatic, 4, 37996.00m, Drivetrain.FrontWheelDrive, FuelType.Hybrid);
            Car enclave = new Car ("Buick", "Enclave", 2011, Color.Black, 22m, BodyStyle.SUV, Transmission.automatic, 6, 11295.00m, Drivetrain.AllWheelDrive, FuelType.Gasoline);
            Car hhr = new Car ("Chevrolet", "HHR", 2007, Color.Red, 22m, BodyStyle.Hatchback, Transmission.manual, 4, 7844.00m, Drivetrain.FrontWheelDrive, FuelType.Gasoline);
            Car modelx = new Car ("Tesla", "ModelX", 2018, Color.White, 95m, BodyStyle.Sedan, Transmission.automatic, 0, 91250.00m, Drivetrain.AllWheelDrive, FuelType.Electric);
            Car volt = new Car ("Chevrolet", "Volt", 2014, Color.Black, 97m, BodyStyle.Sedan, Transmission.automatic, 0, 17350.00m, Drivetrain.FrontWheelDrive, FuelType.Electric);

            Car[] carArr = {maverick, prius, sorento, accord, enclave, hhr, modelx, volt};

            foreach(Car car in carArr)
            {
                switch(car.FuelTypeOptions)
                {
                    case FuelType.Gasoline:
                    AddGasolineCarToList(car);
                    break;
                    case FuelType.Hybrid:
                    AddHybridCarToList(car);
                    break;
                    case FuelType.Electric:
                    AddElectricCarToList(car);
                    break;
                    
                }
                
            }

        }
    }

}