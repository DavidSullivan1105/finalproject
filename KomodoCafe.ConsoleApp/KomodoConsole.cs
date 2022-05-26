using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomodoCafe.repository;
namespace KomodoCafe.ConsoleApp
{
    public class KomodoConsole
    {
        public void PrintMainMenu ()
        {
            Console.WriteLine("Welcome to Komodo Cafe Manager!\n" +
                            "Please enter the number of your selection:\n" + 
                            "1. View Menu \n" +
                            "2. Create A Meal \n" +
                            "3. Delete A Meal \n" +
                            "4. Exit"
                            
            );
        }

        public string GetUserInput()
        {
            return Console.ReadLine();
        }
            
        public int GetUserInputInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public decimal GetAPrice()
        {
            return Convert.ToDecimal(Console.ReadLine());
        }

        public void PrintMenu(Menu item)
        {
            Console.WriteLine($"{item.MealNumber}\n" +
                            $"{item.MealName}\n" +
                            $"{item.Description}\n" +
                            $"{item.Ingredients}\n" +
                            $"{item.Price}\n" +
                            $"{item.SideOptions}\n" +
                            $"{item.DrinkOptions}");
        }

        public void PrintTotalMenu (List<Menu> items)
        {
            foreach(Menu x in items)
            PrintMenu(x);
        }

        public void EnterAMealNumber()
        {
            Console.Write("Enter a Meal Number: ");
        }

        public void EnterAMealName()
        {
            Console.Write("Enter a Meal Name: ");
        }

        public void EnterADescription()
        {
            Console.Write("Enter a brief description of this meal: ");
        }

        public void EnterAPrice()
        {
            Console.Write("Enter a Price: ");
        }
        public void EnterIngredients()
        {

        }

        public void EnterAMealToDelete()
        {
            Console.Write("Please Select a Meal Number To Delete: ");
        }

        public void PressAnyKeyToContinue()
        {
            Console.Write("Press Any Key to Continue...");
            Console.ReadKey();
        }

        public void MealSuccesfullyDeleted(Menu meal)
        {
            Console.WriteLine($"{meal.MealNumber} has been deleted");
        }

        public void SomethingWentWrong()
        {
            Console.WriteLine("Oops...something went wrong");
        }

        public void MealNotFound(int mealNumber)
        {
            Console.WriteLine($"{mealNumber} not found.");
        }

        public void ExitMessage()
        {
            Console.WriteLine("Have A Nice Day!");
        }

    }
}
        

        



