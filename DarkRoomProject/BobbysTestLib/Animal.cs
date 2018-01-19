using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
    public class Animal
    {
        // These are basic properties we set for an object, in this case, an Animal
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Neutered { get; set; }
        public int Weight { get; set; }
        public bool HasOwner { get; set; }
        public string OwnersName { get; set; }
        


        // enums are like attributes of an object. They can be more than that but thats the base you need to know for now.
        public enum Species { Dog, Cat, Bird }
        public enum FurColor { Brown, Black, Orange, Green, Grey }

        public static void Speak(Species species)
        {
            switch (species)
            {
                case Species.Dog:
                    Console.WriteLine(Dog.BaseSpeak);
                    break;
                case Species.Cat:
                    Console.WriteLine(Cat.BaseSpeak);
                    break;
                case Species.Bird:
                    Console.WriteLine(Bird.BaseSpeak);
                    break;
            }
        }
        
    }
}
