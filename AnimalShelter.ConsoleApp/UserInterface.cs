using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalShelter.Repository;

namespace AnimalShelter.ConsoleApp
{
    public class UserInterface
    {
        
        //FIELDS

        //bool isRunning for while loop
        private bool isRunning = true;
        //new up instance of REPO class stored in a variable
        AnimalRepository _repo = new AnimalRepository();

        //METHODS

        //Run
        public void Run();
        {
            _repo.SeedAnimalData();

            while (isRunning)
            {
                PrintMainMenu();

                string input = GetUserInput();
                
            }
        }
        //PrintMainMenu
        private void PrintMainMenu()
        {
           Console.WriteLine("Hello World"); 
        }
        //GetUserInput
        private string GetUserInput()
        {
            return Console.ReadLine();
        }
            
        //CRUD Methods in the context of the UserInterface
    }
}