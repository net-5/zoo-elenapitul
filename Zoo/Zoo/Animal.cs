using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public enum Family
    {
        Horse,
        Tiger,
        Cat,
        Dog,
        Penguin
       
    }

    public class Animal
    {
        //nickname
        private string name;
        //e.g.: horses, tigers
        private Family family;
        private string food;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Family Family
        {
            get
            {
                return family;
            }
            set
            {
                family = value;
            }
        }

        public string Food
        {
            get
            {
                return food;
            }
            set
            {
                food = value;
            }
        }

        public Animal (string name, Family family, string food)
        {
            Name = name;
            Family = family;
            Food = food;
        }

        public string Eat()
        {
            return ($"My name is {Name} and I am {Family}, I eat by myself, my favourite food {Food}.");
        }
    }
}
