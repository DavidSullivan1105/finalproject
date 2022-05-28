using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenPlan.repository;
namespace GreenPlan.ConsoleApp
{
    public class UserInterface
    {
        GreenPlanConsole _console = new GreenPlanConsole();
        GreenPlanRepository _repo = new GreenPlanRepository();
        bool isRunning = true;
        public void Run()
        {
            _repo.SeedCarData();

            while(isRunning)
            {
                _console.PrintMainMenu();

                int userInput = _console.GetUserInputInt();

                UserInputPortal(userInput);

            }
        }

        public void UserInputPortal(int userInputNum)
        {
            switch(userInputNum)
            {
                case 1:
                ViewGasolineVehicles();
                break;
                case 2:
                ViewElectricVehicles();
                break;
                case 3:
                ViewHybridVehicles();
                break;
                case 4:
                CreateNewVehicles();
                break;
                case 5:
                //UpdateExistingVehicles();
                case 6:
                //DeleteVehicles();
                case 7:
                Exit();
                break;
            }
        }

        private void ViewGasolineVehicles()
        {
            List<Car> gasCars = _repo.GetGasolineVehicles();

            _console.PrintAllCars(gasCars);

            _console.PressAnyKeyToContinue();
        }

        private void ViewElectricVehicles()
        {
            List<Car> electricCars = _repo.GetElectricVehicles();

            _console.PrintAllCars(electricCars);

            _console.PressAnyKeyToContinue();
        }

        private void ViewHybridVehicles()
        {
            List<Car> hybridCars = _repo.GetHybridVehicles();

            _console.PrintAllCars(hybridCars);

            _console.PressAnyKeyToContinue();
        }

        private void CreateNewVehicles()
        {
            _console.EnterAMake();
            string newMake = _console.GetUserInput();

            _console.EnterAModel();
            string newModel = _console.GetUserInput();

            _console.EnterAYear();
            int newYear = _console.GetUserInputInt();

            _console.EnterAColor();
            int newColor = _console.GetUserInputInt();

            Color color = Color.Red;

            switch(newColor)
            {
                case 1:
                color = Color.Red;
                break;
                case 2:
                color = Color.Blue;
                break;
                case 3:
                color = Color.Black;
                break;
                case 4:
                color = Color.White;
                break;
                case 5:
                color = Color.Yellow;
                break;
                case 6:
                color = Color.Green;
                break;
                case 7:
                color = Color.Silver;
                break;
                case 8:
                color = Color.Tan;
                break;
                
            }

            _console.EnterMPG();
            int newMPG = _console.GetUserInputInt();

            _console.EnterABodyStyle();
            int newBodyStyle = _console.GetUserInputInt();

            BodyStyle bodyStyle = BodyStyle.CargoVan;

            switch(newBodyStyle)
            {
                case 1:
                bodyStyle = BodyStyle.CargoVan;
                break;
                case 2:
                bodyStyle = BodyStyle.Convertible;
                break;
                case 3:
                bodyStyle = BodyStyle.Coupe;
                break;
                case 4:
                bodyStyle = BodyStyle.Hatchback;
                break;
                case 5:
                bodyStyle = BodyStyle.Minivan;
                break;
                case 6:
                bodyStyle = BodyStyle.PassengerVan;
                break;
                case 7:
                bodyStyle = BodyStyle.PickupTruck;
                break;
                case 8:
                bodyStyle = BodyStyle.SUV;
                break;
                case 9:
                bodyStyle = BodyStyle.Sedan;
                break;
                case 10:
                bodyStyle = BodyStyle.Wagon;
                break;
            }

            _console.EnterTransmissionType();
            int newTransmissionType = _console.GetUserInputInt();

            Transmission transmission = Transmission.automatic;

            switch(newTransmissionType)
            {
                case 1:
                transmission = Transmission.automatic;
                break;
                case 2:
                transmission = Transmission.manual;
                break;
            }

            _console.HowManyCylinders();
            int newCylinders = _console.GetUserInputInt();

            _console.EnterAPrice();
            decimal newPrice = _console.GetUserDecimal();

            _console.DrivetrainType();
            int newDrivetrainType = _console.GetUserInputInt();

            Drivetrain drivetrain = Drivetrain.AllWheelDrive;

            switch(newDrivetrainType)
            {
                case 1:
                drivetrain = Drivetrain.AllWheelDrive;
                break;
                case 2:
                drivetrain = Drivetrain.FourWheelDrive;
                break;
                case 3:
                drivetrain = Drivetrain.FrontWheelDrive;
                break;
                case 4:
                drivetrain = Drivetrain.RearWheelDrive;
                break;
            }

            _console.FuelType();
            int newFuelType = _console.GetUserInputInt();

            FuelType fuelType = FuelType.Electric;

            switch(newFuelType)
            {
                case 1:
                fuelType = FuelType.Electric;
                break;
                case 2:
                fuelType = FuelType.Gasoline;
                break;
                case 3:
                fuelType = FuelType.Hybrid;
                break;
            }

            Car newCar = new Car(newMake, newModel, newYear, color, newMPG, bodyStyle, transmission, newCylinders, newPrice, drivetrain, fuelType);

            _repo.AddGasolineCarToList(newCar);
            _repo.AddElectricCarToList(newCar);
            _repo.AddHybridCarToList(newCar);

        }

        private void Exit()
        {
            _console.ExitMessage();
            _console.PressAnyKeyToContinue();
        }
    }
}