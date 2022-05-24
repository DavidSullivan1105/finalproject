using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomodoCafe.repository;

namespace KomodoCafe.ConsoleApp
{
    public class UserInterface
    {
        KomodoRepository _repo = new KomodoRepository();
        bool isRunning = true;

        KomodoConsole _console = new KomodoConsole();

        public void Run()
        {
            _repo.SeedMenuData();

            while(isRunning)
            {
                _console.PrintMainMenu();

                int userInput = _console.GetUserInputInt();
            }

        }


        public void UserInputPortal(int userInputNum)
        {
            switch(userInputNum)
            {
                case 1:
                //ViewMenu();
                break;
                case 2:
                //OrderValueMeal();
                break;
                case 3:
                //CreateYourOwnMeal();
                break;
                case 4:
                //LeaveAReview();
                break;
                case 5:
                //ExitApp();
                break;
            }
        }
    }

        
}
            

