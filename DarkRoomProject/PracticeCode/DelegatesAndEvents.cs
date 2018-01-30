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
            Func<Person, string> FullName = person => { return $"{person.FirstName} {person.LastName}"; };

            string johnsFullName = FullName(john);
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

    
}
