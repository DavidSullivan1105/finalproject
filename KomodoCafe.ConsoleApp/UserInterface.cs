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

            int userInput = _console.GetUserInputInt();

        }

        public void UserInputPortal(int userInputNum)
        {
            while(isRunning)
            {
                
            }
        }
    }

        
}
            

