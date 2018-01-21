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
        public string FullName { get { return _fullName; } private set { setFullName(); } }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        

        // Get first and last name and combine into one string to make up a full name.
        private string setFullName()
        {
            return "";
        }

        // print to the console that this person first name is calling a new person by their fullname
        public void CallPerson()
        {
            
        }

        // print this person full address
        public void PrintAddress()
        {

        }

        // print a person that is passed in as an argument full address
        public void PrintAddress()
        {

        }

    }
}
