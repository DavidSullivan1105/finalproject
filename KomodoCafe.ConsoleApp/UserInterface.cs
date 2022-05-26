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

                UserInputPortal(userInput);
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
                DeleteAMeal();
                break;
                case 4:
                ExitApp();
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
            int mealNumber = _console.GetUserInputInt();

            _console.EnterAMealName();
            string mealName = _console.GetUserInput();

            _console.EnterADescription();
            string description = _console.GetUserInput();

            _console.EnterIngredients();
            string ingredients = _console.GetUserInput();

            _console.EnterAPrice();
            decimal price = _console.GetAPrice();

            _console.ChooseASide();
            int sideSelection = _console.GetUserInputInt();

            Sides sides = Sides.Fries;

            switch(sideSelection)
            {
                case 1:
                sides = Sides.Fries;
                break;
                case 2:
                sides = Sides.Chips;
                break;
                case 3:
                sides = Sides.MacNCheese;
                break;
                case 4:
                sides = Sides.Salad;
                break;
                case 5:
                sides = Sides.ColeSlaw;
                break;
                case 6:
                sides = Sides.Apple;
                break;
            }

            _console.ChooseADrink();
            int drinkSelection = _console.GetUserInputInt();

            Drinks drinks = Drinks.Coke;

            switch(drinkSelection)
            {
                case 1:
                drinks = Drinks.Coke;
                break;
                case 2:
                drinks = Drinks.DietCoke;
                break;
                case 3:
                drinks = Drinks.Sprite;
                break;
                case 4:
                drinks = Drinks.DrPepper;
                break;
                case 5:
                drinks = Drinks.Lemonade;
                break;
                case 6:
                drinks = Drinks.IcedTea;
                break;
            }

            Menu newMenu = new Menu(mealNumber, mealName, description, ingredients, price, sides, drinks);

            _repo.AddMenuToDataBase(newMenu);
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

        private void ExitApp()
        {
            _console.ExitMessage();
            isRunning = false;

        }

    }   
}





            

