using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Repository
{
    public class AnimalRepository
    {
        //FAKE DATABASE
        private List<Animal> _animalListDB = new List<Animal>();



        //CRUD METHODS

        //Create

        //CreateAnimal
        public void AddAnimalToDatabase(Animal animal)
        {
            _animalListDB.Add(animal);
        }

        //Read

        //GetAllAnimals

        //GetAnimal



        //Update

        //UpdateAnimal



        //Delete

        //DeleteAnimal




        //SEED DATA
        public void SeedAnimalData()
        {
            Animal tucker = new Animal("Tucker", DietType.carnivore, 1, "Dog");
            Animal zelda = new Animal("Zelda", DietType.carnivore, 3, "Cat");
            Animal finn = new Animal("Finn", DietType.carnivore, 1, "Praying Mantis");

            Animal[] animalArr = {tucker, zelda, finn};

            foreach (Animal x in animalArr)
            {
                AddAnimalToDatabase(x);
            }
        }
    }
}