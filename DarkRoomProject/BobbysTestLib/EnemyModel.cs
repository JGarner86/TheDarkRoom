using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BobbysTestLib
{
    public class EnemyModel
    {
        public static int EnemyCount { get; private set; }
        private int _enemyCount;

        public string Name { get; set; }
        public int Health { get; set; }
        public int Stamina { get; set; }
        public string Weapon { get; set; }

        public EnemyModel()
        {
            _enemyCount++;
        }
        
    }
}
