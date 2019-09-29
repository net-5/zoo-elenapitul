using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Zoo
    {
        private string nameZoo;
        private List<Animal> animals = new List<Animal>();

        public string NameZoo
        {
            get
            { return nameZoo; }
            set
            { nameZoo = value; }
        }

        public List<Animal> Animals
        {
            get
            {
                return animals;
            }
            set
            {
                animals = value;
            }
        }

        public Zoo (string nameZoo)
        {
            NameZoo = nameZoo;
        }
                     

        public void AddAnimal (Animal animalToAdd)
        {
            if (Animals.Contains(animalToAdd))
            {
                Console.WriteLine("This animal is already in the system.");
            }
            else
            {
                this.Animals.Add(animalToAdd);
                Console.WriteLine($"The {animalToAdd.Name} is added to the zoo {NameZoo}.");
            }            
           
        }       

        public void TransferAnimal (Animal animalToTransfer, Zoo currentZoo, Zoo newZoo)
        {

            if (Animals.Contains(animalToTransfer))
            {
                currentZoo.animals.Remove(animalToTransfer);
                newZoo.AddAnimal(animalToTransfer);
                Console.WriteLine($"The {animalToTransfer.Name} is leaving the zoo {currentZoo.NameZoo} to {newZoo.NameZoo}.");
            }

            else{
                Console.WriteLine("This animal is not in this zoo.");
            }
            
        }

        public void Details()
        {

            Console.WriteLine($"The {NameZoo} has {Animals.Count} animals:");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Eat());
            }
        }

                
    }
}
