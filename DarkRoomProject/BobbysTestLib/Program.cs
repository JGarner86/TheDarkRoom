using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;


namespace BobbysTestLib
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            path += "\\CharacterData.txt";
            Console.WriteLine(path);
            Console.ReadLine();
            List<EnemyModel> enemyList = new List<EnemyModel>();

            DataModel.FetchData(ref enemyList, path);

            foreach (var enemy in enemyList)
            {
                Console.WriteLine("Enemy Name: {0} |  Health: {1}  |  Stammina: {2}  |  Weapon: {3}", enemy.Name, enemy.Health, enemy.Stamina, enemy.Weapon);

            }
            Console.ReadLine();



            #region    Animal Example Code      
            //Animal.Species _cat, _dog, _bird = new Animal.Species();

            //_cat = Animal.Species.Cat;
            //_dog = Animal.Species.Dog;
            //_bird = Animal.Species.Bird;
            //Bird TweetyBird = new Bird();



            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Ask for a cat, dog, or bird call.");
            //    string userInput = Console.ReadLine().ToLower();
            //    if (userInput == "cat")
            //    {
            //        Animal.Speak(_cat);

            //    }
            //    else if (userInput == "dog")
            //    {
            //        Animal.Speak(_dog);
            //    }
            //    else if (userInput == "bird")
            //    {
            //        Animal.Speak(_bird);
            //        Console.WriteLine("Number of legs: " + TweetyBird.Legs);
            //    }
            //    Console.WriteLine("Ask for another animal? Y for yes, Esc to quit.");
            //} while (Console.ReadKey().Key != ConsoleKey.Escape);
            #endregion
        }
    }
}
