using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomodoCafe.repository
{
    public class Menu
    {
        //Properties
        public int MealNumber { get; set; }

        public string MealName { get; set; }

        public string Description { get; set; }

        public string[] Ingredients { get; set; }

        public decimal Price { get; set; }

        public Sides SideOptions { get; set; }

        public Drinks DrinkOptions { get; set; }

        //Full Constructor
        public Menu (int mealNumber, string mealName, string description, string[] ingredients, decimal price, Sides sideOptions, Drinks drinkOptions)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
            Price = price;
            SideOptions = sideOptions;
            DrinkOptions = drinkOptions;

        }

        //Empty Constructor
        public Menu (){}

    }
    //enums
    public enum Sides { Fries, Chips, MacNCheese, Salad, ColeSlaw, Apple}
    public enum Drinks { Coke, DietCoke, Sprite, DrPepper, Lemonade, IcedTea}
}