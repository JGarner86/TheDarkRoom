using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{


    public class DelegatesAndEvents
    {
        /// <summary>
        /// This will be the method called in program to run your test, so put the code that you want to run in here, then call it in program.cs
        /// </summary>


        
        public static void RunCode()
        {

            
            Person john = new Person()
            {
                FirstName = "John",
                LastName = "Smith"
            };
            Func<Person, int, string> FullName = (person, age) => { return $"{person.FirstName} {person.LastName} is {age} years old."; };

            string johnsFullName = FullName(john, 45);
            Console.WriteLine(johnsFullName);
            
            
        }

    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static string FullName(Person person)
        {
            return $"{person.FirstName} {person.LastName}";
        }
    }

    public delegate void SlapEventHandler(object sender, SlapEventArgs args);

    public class SlapEventArgs : EventArgs
    {
        public string SlapType { get; set; } = "Bitch Slapped";
    }
    public class Slap
    {
        public event SlapEventHandler Slapped;

        public void BitchSlapped(Person slappedBy, Person person)
        {
            Slapped(this, new SlapEventArgs());
        }
    }

    
}
