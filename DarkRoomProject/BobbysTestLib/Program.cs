using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BobbysTestLib
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
            Animal.Species _cat, _dog, _bird, _Monkey = new Animal.Species();

            _cat = Animal.Species.Cat;
            _dog = Animal.Species.Dog;
            _bird = Animal.Species.Bird;
            _Monkey = Animal.Species.Monkey;

         

            do
            {
                Console.WriteLine("Ask for a cat, dog, or bird call.");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "cat")
                {
                    Animal.Speak(_cat);

                }
                else if (userInput == "dog")
                {
                    Animal.Speak(_dog);
                }
                else if (userInput == "bird")
                {
                    Animal.Speak(_bird);
                }
                else if (userInput == "monkey")
                {
                    Animal.Speak(_Monkey);
                }
                Console.WriteLine("Ask for another animal? Y for yes, Esc to quit.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
