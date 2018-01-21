+using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
    public class SimpleMath
    {
        // Make this add method work by letting the caller pass in two arguments and you return the result of adding the two arguments together.
        public static int AddTwoNumbers(int number1, int number2)
        {          
            return number1 + number2;
        }

        // Make this minus method work by letting the caller pass in two arguments and you return the result of minusing one argument from the other.
        public static int MinusTwoNumbers(int number4, int number2)
        {
            return number4 - number2;
        }

        // Make this times method work by letting the caller pass in two arguments and you return the result of multiplying the two arguments together.
        public static int TimesTwoNumbers(int number5, int number3)
        {
            return number5 * number3;
        }

        // Make this divide method work by letting the caller pass in two arguments and you return the result of dividing one argument from the other.
        public static int DivideTwoNumbers(int number6, int number9)
        {
            return number6 / number9;
        }

        // Make this equals method work by letting the caller pass in two arguments and you return a true if they are equal, false if they are not.
        public static bool CheckIfTwoNumbersAreEqual(int number7, int number8)
        {
            if (number7 == number8)
            {
                return true;
            }
            else
            {
                return false;
            }
            
           
        }
    }   
}
