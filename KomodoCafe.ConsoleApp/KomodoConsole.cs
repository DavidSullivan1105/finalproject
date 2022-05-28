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
            Console.WriteLine("\nWelcome to Komodo Cafe Manager!\n" +
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
            Console.WriteLine($"Meal Number: {item.MealNumber}\n" +
                            $"Meal Name: {item.MealName}\n" +
                            $"Description: {item.Description}\n" +
                            $"Ingredients: {item.Ingredients}\n" +
                            $"Price: {item.Price}\n" +
                            $"Side: {item.SideOptions}\n" +
                            $"Drink: {item.DrinkOptions}");
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
            Console.Write("Please list ingredients: ");
            
        }

        public void ChooseASide()
        {
            Console.Write("Please select a side: \n" +
                        "1. Fries \n" +
                        "2. Chips \n" +
                        "3. MacNCheese \n" +
                        "4. Salad \n" +
                        "5. ColeSlaw \n" +
                        "6. Apple \n" );
        }

        public void ChooseADrink()
        {
            Console.Write("Please select a drink: \n" +
                        "1. Coke \n" +
                        "2. Diet Coke \n" +
                        "3. Sprite \n" +
                        "4. Dr Pepper \n" +
                        "5. Lemonade \n" +
                        "6. Iced Tea \n");
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
            Console.WriteLine("Have A Nice Day! \n");
            
        }

    }
}
        

        



