using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace BobbysTestLib
{
    public class DataModel
    {
        public static void FetchData(ref List<EnemyModel> _enemyList, string _path)
        {
            using (var reader = new StreamReader(_path))
            {
                
                while (!reader.EndOfStream)
                {
                    int counter = 1;
                    EnemyModel enemy = new EnemyModel();
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    foreach(var data in values)
                    {
                        switch (counter)
                        {
                            case 1:
                                enemy.Name = data;
                                break;
                            case 2:
                                enemy.Health = Convert.ToInt32(data);
                                break;
                            case 3:
                                enemy.Stamina = Convert.ToInt32(data);
                                break;
                            case 4:
                                enemy.Weapon = data;
                                break;

                        }
                        counter++;
                    }
                    _enemyList.Add(enemy);
                    

                }
            }
            
        }
    }
}
