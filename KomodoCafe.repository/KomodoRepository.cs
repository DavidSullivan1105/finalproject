using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomodoCafe.repository
{
    public class KomodoRepository
    {
        //Menu DB
        List<Menu> _menuDB = new List<Menu>();

        //Create
        public void AddMenuToDataBase(Menu menu)
        {
            _menuDB.Add(menu);
        }
        


        //Read
        public List<Menu> GetMenu()
        {
            return _menuDB;
        }



        //Update



        //Delete



        //Seed Menu Data Method
        public void SeedMenuData()
        {
            Menu italian = new Menu( 1, "When in Rome", "A classic italian sub w/ a side and drink", "ham , salami, peperoni, provolone, lettuce, red onion, banana pepper, oil + vinegar", 8.99m, Sides.Fries, Drinks.Lemonade);
            Menu cuban = new Menu( 2, "Bay of Pigs", "A sandwich fit for Castro w/ a side and drink", "ham, swiss, dill pickle chips, mustard", 7.99m, Sides.Fries, Drinks.Coke);
            Menu reuben = new Menu( 3, "The Rube", "The Reuben as it should be w/ a side and drink", "marbled rye bread, corned beef, swiss, sauerkraut, thousand island dressing", 8.99m, Sides.Fries, Drinks.Coke);
            Menu meatball = new Menu( 4, "Sammy with a Chance of Meatballs", "A meatball sub for any weather w/ a side and drink", "french bread, our delicious pork meatballs, marinara, mozzarella", 8.99m, Sides.Fries, Drinks.Lemonade);
        
            Menu[] menuArr = { italian, cuban, reuben, meatball };

            foreach(Menu x in menuArr)
            {
                AddMenuToDataBase(x);
            }


        }
    }
}