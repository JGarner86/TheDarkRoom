using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
    public class Person
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
       
        private string _fullName;
        public string FullName { get { return setFullName(); } }  
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public static int Count { get; private set; }

        public Person()
        {

        }

        public Person(string _firstName, string _lastName)
        {
            FirstName = _firstName;
            LastName = _lastName;
            Count++;

        }
        

        // Get first and last name and combine into one string to make up a full name.
        private string setFullName()
        {
            _fullName = FirstName + " " + LastName;
            return _fullName;
        }

        // print to the console that this person first name is calling a new person by their fullname
        public void CallPerson(Person person)
        {
            Console.WriteLine($"{FirstName} is calling {person.FullName}");

        }

        // print this person full address
        public void PrintAddress()
        {
            Console.WriteLine(Street);
            Console.WriteLine($"{City}, {State}, {Zip}");
        }

        // print a person that is passed in as an argument full address
        public void PrintAddress(Person person)
        {
            Console.WriteLine(person.Street);
            Console.WriteLine($"{person.City}, {person.State}, {person.Zip}");




    }   }
}
