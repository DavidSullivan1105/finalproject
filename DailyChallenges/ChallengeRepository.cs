using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyChallenges
{

    public class menu
    { 
    public Burgers BurgerOptions { get; set; }
    public Sandwiches SandwichOptions { get; set;}
    public Drinks DrinkOptions { get; set; }
    public Breakfast BreakfastOptions { get; set; }

    public menu (Burgers burgerOptions, Sandwiches sandwhichOptions, Drinks drinksOptions, Breakfast breakfastOptions)
    {
      BurgerOptions = burgerOptions;
      SandwichOptions = SandwichOptions;
      DrinkOptions = drinksOptions;
      BreakfastOptions = breakfastOptions;
    }

    public menu(){}
      
    }
  public enum Burgers { BigMac, QuarterPounder, Mcdouble, DoubleCheeseburger, Cheeseburger, Hamburger }
  public enum Sandwiches { DeluxeCrispyChicken, SpicyDeluxeCrispyChicken, CrispyChicken, ChickenNuggets, McChicken, FiletOFish }
  public enum Drinks { Coke, DietCoke, Sprite, Fanta, DrPepper, HiCOrange, SweetTea, UnsweetenedTea, Water, Milk, Coffee }
  public enum Breakfast { BaconEggCheeseBiscuit, EggMcMuffin, SausageMcMuffin, SauageMcMuffinWithEgg, SausageBiscuit, SauageBiscuitWithEgg, BaconEggCheeseMcGriddle, SauageEggCheeseMcGriddle, BigBreakfast, Hotcakes, SausageBurrito, HashBrowns, FruitandMapleOatmeal }

  public class Birthday
  {

    public string NumberOfDaysIveBeenAlive(string birthday)
    {
      string mybirthday = "11/05/1980";
      
    }
  }

  public class List
  {
    public Dictionary<string, decimal> FindMMM (List<int> intList)
    {
      Dictionary<string, decimal> meanMedianModeDict = new Dictionary<string, decimal>();
      decimal mean = Mean(intList);
      decimal median = Median(intList);
      decimal mode = Mode(intList);

      meanMedianModeDict.Add("mean", mean);
      meanMedianModeDict.Add("median", median);
      meanMedianModeDict.Add("mode", mode);

      return meanMedianModeDict;

    }
    


    private decimal Mean(List<int> intList)
    {
      decimal mean = intList.Count > 0 ? (decimal)(intList.Average()) : 0.0m;

      return mean;

    }

    private decimal Median(List<int> intList)
    {
      intList.Sort();
      decimal median;
      if(intList.Count % 2 != 0)
      {
        int x = intList[(intList.Count / 2)];
      }
      else
      {
        int x = intList[(intList.Count / 2)];
        int y = intList[(intList.Count / 2) - 1];

        median = (x+y) / 2;
      }

      return median;
    }

    private decimal Mode(List<int> intList)
    {
      int mode

      return mode;
    }
  }
 }
  