using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BobbysTestLib
{
    public class TestModule
    {



        public static void RunTest()
        {
            //Test(SimpleMath.AddTwoNumbers(4, 3), 7, "AddTwoNumbers");
            //Test(SimpleMath.MinusTwoNumbers(10, 5), 5, "MinusTwoNumbers");
            //Test(SimpleMath.TimesTwoNumbers(6, 3), 18, "TimesTwoNumbers");
            //Test(SimpleMath.DivideTwoNumbers(10, 100), 10, "DivideTwoNumbers");
            //Test(SimpleMath.CheckIfTwoNumbersAreEqual(5, 5), true, "CheckIfTwoNumbersAreEqual");
            
        }

        public static void RunTest(Person personA, Person personB)
        {
            Person Bobby = new Person
            {
                FirstName = "Bobby",
                LastName = "Brooks",
                City = "Midland",
                State = "Tx",
                Street = "354 Midkiff",
                Zip = "79705",
                PhoneNumber = "432-555-2365",
                
            };

            Person Josh = new Person
            {
                FirstName = "Josh",
                LastName = "Garner",
                City = "Cedar Park",
                State = "Tx",
                Street = "610 Cheyenne Ln",
                Zip = "78613",
                PhoneNumber = "737-212-4225",

            };

            Bobby.CallPerson(Josh);
            Bobby.PrintAddress();



        }

        private static void Test(int method, int expectedResult, string name)
        {

            if (method == expectedResult)
            {
                Console.WriteLine($"{name} method: passed");
            }
            else
            {
                Console.WriteLine($"{name} method: failed");
            }
        }

        private static void Test(bool method, bool expectedResult, string name)
        {
            Test(method, expectedResult, name);
        }

        
    }
}
