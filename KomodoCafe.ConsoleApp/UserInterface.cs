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
                ViewMenu();
                break;
                case 2:
                CreateAMeal();
                break;
                case 3:
                //DeleteAMeal;
                break;
                case 4:
                //ExitApp();
                break;
                
            }
        }

        private void ViewMenu()
        {
            List<Menu> totalMenu = _repo.GetMenu();

            _console.PrintTotalMenu(totalMenu);

            _console.PressAnyKeyToContinue();
        }

        private void CreateAMeal()
        {
            _console.EnterAMealNumber();
            int newMealNum = _console.GetUserInputInt();

            _console.EnterAMealName();
            string newMealName = _console.GetUserInput();

            _console.EnterADescription();
            string newMealDescription = _console.GetUserInput();



            _console.EnterAPrice();
            decimal newMealPrice = _console.GetAPrice();
        }

        private void DeleteAMeal()
        {
            ViewMenu();

            _console.EnterAMealToDelete();
            int mealNumberToDelete = _console.GetUserInputInt();

            Menu mealToDelete = _repo.GetMealByNumber(mealNumberToDelete);

            if(mealToDelete != null)
            {
                bool isSuccess = _repo.DeleteMealFromDatabase(mealToDelete);

                if(isSuccess)
                {
                    _console.MealSuccesfullyDeleted(mealToDelete);
                }
                else
                {
                    _console.SomethingWentWrong();
                }
            }
            else
            {
                _console.MealNotFound(mealNumberToDelete);
            }
            _console.PressAnyKeyToContinue();
        }

    }   
}





            

