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
            Test(SimpleMath.AddTwoNumbers(4, 3), 7, "AddTwoNumbers");
            Test(SimpleMath.MinusTwoNumbers(10, 5), 5, "MinusTwoNumbers");
            Test(SimpleMath.TimesTwoNumbers(6, 3), 18, "TimesTwoNumbers");
            Test(SimpleMath.DivideTwoNumbers(100, 10 ), 10, "DivideTwoNumbers");
           // Test(SimpleMath.CheckIfTwoNumbersAreEqual(5, 5), true, "CheckIfTwoNumbersAreEqual");
            
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
