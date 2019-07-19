using System;
using System.Collections.Generic;
using System.Text;


namespace Zoo
{
    public class Zoo 
    {
        private string nameZoo;
        private string[] listAnimals = new string [5];

        private string nameAnimal;
        private string nicknameID;
        private string favoriteFood;

        public static int count;

        //private DateTime arrivalDate;
        //private DateTime departureDate;
        
        public string NameZoo
        {
            get { return nameZoo; }
            set { nameZoo = value; }
        }

        public string[] ListAnimals
        {
            get { return listAnimals; }
            set { listAnimals = value; }
        }

        public string NameAnimal
        {
            get { return nameAnimal; }
            set { nameAnimal = value; }
        }

        public string NicknameID
        {
            get { return nicknameID; }
            set { nicknameID = value; }
        }

        public string FavoriteFood
        {
            get { return favoriteFood; }
            set { favoriteFood = value; }
        }
        

        static void AddAnimal()
        {
            count = 0;
        }
       
        public void AddAnimal(string name, string nickname)
         {
            if(count < ListAnimals.Length)
            {
                NameAnimal = name;
                NicknameID = nickname;
                count++;
                ListAnimals[count - 1] = name;
                Console.WriteLine("Add " + NameAnimal + " called " + NicknameID);
            }
            
             else
             {
                 Console.WriteLine("Full capacity.");
             }

         }
                 
        
        public void TransferAnimal(string name)
        {
            int index = Array.IndexOf(ListAnimals, name);
            if (index >= 0)
            {
                ListAnimals[index] = "";
                count--;
                Console.WriteLine(NameAnimal + " has left " + NameZoo);
            }           

        }

        public void Eat(string nickname, string food)
        {
            NicknameID = nickname;
            FavoriteFood = food;
            Console.WriteLine(NicknameID + " loves to eat " + FavoriteFood);
        }

        public void Info()
        {
            Console.WriteLine("In " + NameZoo + " there are " + count + " animals");
            /*foreach (string item in ListAnimals)
            {
                if(item != "")
                Console.WriteLine(item);
            }*/
        }
    }
}
