using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenPlan.ConsoleApp
{
    public class GreenPlanConsole
    {
        public void PrintMainMenu()
        {
            Console.WriteLine("Welcome to the Komodo Insurance Green Plan Manager! \n" +
                            "The best way to manage vehicle data for the green future! \n" +
                            "Please select a number from the following options: \n" +
                            "1. View Gasoline Vehicles \n" +
                            "2. View Electric Vehicles \n" +
                            "3. View Hybrid Vehicles \n" +
                            "4. Create New Vehicles \n" +
                            "5. Update Existing Vehicles \n" +
                            "6. Delete Vehicles \n" +
                            "7. Exit");
        }

        public int GetUserInputInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public void PressAnyKeyToContinue()
        {
            Console.Write("Press Any Key to Continue...");

            Console.ReadKey();
        }
    }
}