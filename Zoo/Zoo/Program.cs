using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Model a ZOO keeping in mind that:
            //A zoo has a name and a list of animals
            //At a zoo they can bring new animals and transfer animals to new zoos
            //At a zoo the animals are daily fed with their favorite food, and each animal eats what it loves to eat.
            //Each animal knows to eat by itself, and not all animals of the same type prefer the same type of food. 
            //Eg; a horse prefers carrots, and another horse prefers apples

            Zoo globalZoo = new Zoo("Global Zoo");
            Zoo worldZoo = new Zoo("World Zoo");

            Animal horseOne = new Animal("Horse One", Family.Horse, "Carrots");
            Animal horseTwo = new Animal("Horse Two", Family.Horse, "Apples");

            globalZoo.AddAnimal(horseOne);
            worldZoo.AddAnimal(horseTwo);
            
            globalZoo.Details();
            worldZoo.Details();

            globalZoo.TransferAnimal(horseOne, globalZoo, worldZoo);

            globalZoo.Details();
            worldZoo.Details();

            globalZoo.TransferAnimal(horseOne, globalZoo, worldZoo);

            globalZoo.Details();
            worldZoo.Details();

            horseOne.Eat();
            horseTwo.Eat();

            worldZoo.TransferAnimal(horseTwo, worldZoo, globalZoo);

        }
    }
}
