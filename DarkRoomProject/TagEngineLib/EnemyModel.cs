using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagEngineLib
{
	public class EnemyModel
    {
		public string Name { get; set; }
        public int Health { get;set; }

        public void TakePotion(int Amount)
        {
            this.Health += Amount;




        } 
	


	}

}
