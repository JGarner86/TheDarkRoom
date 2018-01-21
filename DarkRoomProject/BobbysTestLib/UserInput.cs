using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
    public class UserInput
    {
        //
        public static void CheckingPress(string Letter1,string dialog)
        {
            Console.WriteLine(dialog);            
            string value = Console.ReadLine();
            if (Letter1 == value) 
            {
                


            }
            else
            {
                testgame.gameover();
                

            }
            
        
             

        }
        public static void CheckingPress(string Letter1, string dialog1, string dialog2, string Letter2, string Basedialog)
        {
            Console.WriteLine(Basedialog);
            string value = Console.ReadLine();
            if (Letter1 == value)
            {

                Console.WriteLine(dialog1);


            }
            else if(Letter2 == value)
            {
                Console.WriteLine(dialog2); 

            }
            else
            {
                
                testgame.gameover();


            }
            

            
            


            




        }





    }
}