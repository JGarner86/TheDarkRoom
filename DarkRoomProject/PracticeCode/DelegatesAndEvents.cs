using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{

    delegate void Operation(int num);

    public class DelegatesAndEvents
    {
        /// <summary>
        /// This will be the method called in program to run your test, so put the code that you want to run in here, then call it in program.cs
        /// </summary>
        public static void RunCode()
        {
            Operation doub = Double;
            doub(2);
            doub += Triple;
            doub += Double;//
            doub(3);

        }

        static void Double(int num)
        {
            Console.WriteLine($"{num} x 2 = {num * 2}");
        }

        static void Triple(int num)
        {
            Console.WriteLine($"{num} x 3 = {num * 3}");
        }


    }
}
