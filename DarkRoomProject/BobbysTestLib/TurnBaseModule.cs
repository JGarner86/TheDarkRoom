using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbysTestLib
{
    class TurnBaseModule
    {
        const ConsoleKey swordSlash = ConsoleKey.G;
        const ConsoleKey finalSlash = ConsoleKey.F;
        const ConsoleKey sideArm = ConsoleKey.D;
        const ConsoleKey primaryWeapon = ConsoleKey.A;
        const ConsoleKey secondaryWeapon = ConsoleKey.S;

  
        
        public void AttackPhase()
        {
            Enemy testEnemy = new Enemy();
            Player testPlayer = new Player();
            while (testEnemy.Health > 0 )
            {
                switch (UserController.UserKeyPress)
                {
                    case swordSlash:
                        testPlayer.SwordSlash(testEnemy);
                        break;

                    case finalSlash:
                        testPlayer.FinalSlash(testEnemy);
                        break;
                    
                        

                }

            }


        }
               

    }

}
