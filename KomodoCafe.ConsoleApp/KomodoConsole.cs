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
            Console.WriteLine("Welcome to Komodo Cafe!\n" +
                            "Please enter the number of your selection:\n" + 
                            "1. View Menu \n" +
                            "2. Gimme A Meal \n" +
                            "3. Create My Own Meal \n" +
                            "4. Leave a Review \n" +
                            "5. Exit"
            );
        }
            
        public int GetUserInputInt()
        {
            return Convert.ToInt32(Console.ReadLine());
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

        




    }
}