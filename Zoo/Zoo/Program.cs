using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo myZoo = new Zoo();
            myZoo.NameZoo = "Zoo INC.";
            myZoo.AddAnimal("Pisica", "Tom");
            myZoo.Eat("Tom", "mice");
            myZoo.AddAnimal("Pisica", "Sylvester");
            myZoo.Eat("Sylvester", "store bought");
            myZoo.AddAnimal("Caine", "Cutu");
            myZoo.Eat("Cutu", "anything");
            myZoo.Info();

            myZoo.TransferAnimal("Caine");
            myZoo.Info();

            

        }
    }
}
