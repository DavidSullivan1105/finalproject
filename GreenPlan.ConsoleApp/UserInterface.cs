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
                UpdateExistingVehicles();
                break;
                case 6:
                DeleteVehicles();
                break;
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

            switch(newCar.FuelTypeOptions)
            {
                case FuelType.Gasoline:
                _repo.AddGasolineCarToList(newCar);
                break;
                case FuelType.Electric:
                _repo.AddElectricCarToList(newCar);
                break;
                case FuelType.Hybrid:
                _repo.AddHybridCarToList(newCar);
                break;
            }

        }

        private void UpdateExistingVehicles()
        {
            List<Car> allCars = _repo.GetMasterList();

            _console.PrintAllCars(allCars);

            _console.EnterMakeToUpdate();
            string makeUpdate = _console.GetUserInput();

            _console.EnterModelToUpdate();
            string modelUpdate = _console.GetUserInput();

            _console.EnterYearToUpdate();
            int yearUpdate = _console.GetUserInputInt();

            Car carToUpdate = _repo.GetCarByMakeModelYear(makeUpdate, modelUpdate, yearUpdate);

            if (carToUpdate != null)
            {
                _console.PrintCars(carToUpdate);

                Console.Write("New Make: ");
                string updatedMake = _console.GetUserInput();

                Console.Write("New Model: ");
                string updatedModel = _console.GetUserInput();

                Console.Write("New Year: ");
                int updatedYear = _console.GetUserInputInt();

                Console.WriteLine("New Color: \n"+
                                "1. Red \n" +
                            "2. Blue \n" +
                            "3. Black \n" +
                            "4. White \n" +
                            "5. Yellow \n" +
                            "6. Green \n" +
                            "7. Silver \n" +
                            "8. Tan \n");

                int updatedColor = _console.GetUserInputInt();

                Color newcolor = carToUpdate.ColorOptions;

                switch(updatedColor)
            {
                case 1:
                newcolor = Color.Red;
                break;
                case 2:
                newcolor = Color.Blue;
                break;
                case 3:
                newcolor = Color.Black;
                break;
                case 4:
                newcolor = Color.White;
                break;
                case 5:
                newcolor = Color.Yellow;
                break;
                case 6:
                newcolor = Color.Green;
                break;
                case 7:
                newcolor = Color.Silver;
                break;
                case 8:
                newcolor = Color.Tan;
                break;
                
            }

            Console.Write("New MPG: ");
            decimal updatedMPG = _console.GetUserDecimal();

            Console.WriteLine("New body style: \n" +
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

            int updatedBodyStyle = _console.GetUserInputInt();

            BodyStyle newBody = carToUpdate.BodyStyleOptions;

            switch(updatedBodyStyle)
            {
                case 1:
                newBody = BodyStyle.CargoVan;
                break;
                case 2:
                newBody = BodyStyle.Convertible;
                break;
                case 3:
                newBody = BodyStyle.Coupe;
                break;
                case 4:
                newBody = BodyStyle.Hatchback;
                break;
                case 5:
                newBody = BodyStyle.Minivan;
                break;
                case 6:
                newBody = BodyStyle.PassengerVan;
                break;
                case 7:
                newBody = BodyStyle.PickupTruck;
                break;
                case 8:
                newBody = BodyStyle.SUV;
                break;
                case 9:
                newBody = BodyStyle.Sedan;
                break;
                case 10:
                newBody = BodyStyle.Wagon;
                break;
            }

            Console.WriteLine("New transmission: \n" +
                            "1. Automatic \n" +
                            "2. Manual");

            int updatedTransmission = _console.GetUserInputInt();

            Transmission newTrans = carToUpdate.TransmissionOptions;

            switch(updatedTransmission)
            {
                case 1:
                newTrans = Transmission.automatic;
                break;
                case 2:
                newTrans = Transmission.manual;
                break;
            }

            Console.Write("New cylinders: ");
            int updatedCylinders = _console.GetUserInputInt();

            Console.Write("New price: ");
            decimal updatedPrice = _console.GetUserDecimal();

            Console.WriteLine("New drivetrain: \n" +
                            "1. All Wheel Drive \n" +
                            "2. 4 Wheel Drive \n" +
                            "3. Front Wheel Drive \n" +
                            "4. Rear Wheel Drive");

            int updatedDrivetrain = _console.GetUserInputInt();

            Drivetrain newDrive = carToUpdate.DrivetrainOptions;

            switch(updatedDrivetrain)
            {
                case 1:
                newDrive = Drivetrain.AllWheelDrive;
                break;
                case 2:
                newDrive = Drivetrain.FourWheelDrive;
                break;
                case 3:
                newDrive = Drivetrain.FrontWheelDrive;
                break;
                case 4:
                newDrive = Drivetrain.RearWheelDrive;
                break;
            }

            Console.WriteLine("New Fueltype \n" +
                            "1. Gasoline \n" +
                            "2. Electric \n" +
                            "3. Hybrid");

            int updatedFuelType = _console.GetUserInputInt();

            FuelType newfuel = carToUpdate.FuelTypeOptions;

            switch(updatedFuelType)
            {
                case 1:
                newfuel = FuelType.Gasoline;
                break;
                case 2:
                newfuel = FuelType.Electric;
                break;
                case 3:
                newfuel = FuelType.Hybrid;
                break;
            }

            Car updatedCar = new Car(updatedMake, updatedModel, updatedYear, newcolor, updatedMPG, newBody, newTrans, updatedCylinders, updatedPrice, newDrive, newfuel);

            if(updatedCar.Make == carToUpdate.Make)
            {
                bool isComplete = _repo.UpdateCar(updatedCar);
                Console.WriteLine("Car successfully updated");
            }
            else
            {
                bool isComplete = _repo.UpdateCar(updatedCar, carToUpdate.Make);
                Console.WriteLine("Car succesfully updated");


            }
            
            





            }
            else
            {
                _console.CarNotFound();
                _console.PressAnyKeyToContinue();
            }




        }

        private void DeleteVehicles()
        {
            List<Car> allCars = _repo.GetMasterList();
            

            _console.PrintAllCars(allCars);

            _console.EnterMakeToDelete();
            string deleteMake = _console.GetUserInput();

            _console.EnterModelToDelete();
            string deleteModel = _console.GetUserInput();

            _console.EnterYearToDelete();
            int deleteYear = _console.GetUserInputInt();

            Car carToDelete = _repo.GetCarByMakeModelYear(deleteMake, deleteModel, deleteYear);

            if(carToDelete != null)
            {
                bool isSuccess = _repo.DeleteCarFromMasterList(carToDelete);
                if(isSuccess)
                {
                    _console.CarSuccessfullyDeleted();
                    switch(carToDelete.FuelTypeOptions)
                    {
                        case FuelType.Gasoline:
                        _repo.RemoveCarFromGasList(carToDelete);
                        break;
                        case FuelType.Electric:
                        _repo.RemoveCarFromElectricList(carToDelete);
                        break;
                        case FuelType.Hybrid:
                        _repo.RemoveCarFromHybridList(carToDelete);
                        break;
                    }
                    
                }
                else
                {
                    _console.SomethingWentWrong();
                }
            }
            else
            {
                _console.CarNotFound();
            }
            
            
            
            //_console.PressAnyKeyToContinue();
        }

        private void Exit()
        {
            _console.ExitMessage();
            _console.PressAnyKeyToContinue();
        }
    }
}