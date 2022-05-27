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
                //CreateNewVehicles();
                break;
                case 5:
                //UpdateExistingVehicles();
                case 6:
                //DeleteVehicles();
                case 7:
                //Exit();
                break;
            }
        }

        private void ViewGasolineVehicles()
        {
            _repo.GetGasolineVehicles();

            _console.PressAnyKeyToContinue();
        }

        private void ViewElectricVehicles()
        {
            _repo.GetElectricVehicles();

            _console.PressAnyKeyToContinue();
        }

        private void ViewHybridVehicles()
        {
            _repo.GetHybridVehicles();

            _console.PressAnyKeyToContinue();
        }
    }
}