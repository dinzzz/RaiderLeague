using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaiderLeague.Models
{
    public class Operation
    {


        public int ID { get; set; }
        public String OperationName { get; set; }

        public Difficulty? difficulty { get; set; } // dodati ovo u dijagram klasa
        public virtual ICollection<Boss> bosses { get; set; } 
        public virtual ICollection<BattleLog> dnevnici { get; set; }

        /*public Operation(String operationName)
        {
            
            this.OperationName = operationName;
            Bosses = new List<Boss>();
        }*/
        /*
        public Boss getSpecificBoss(int index)
        {
            return Bosses.ElementAt(index);
        }

        public void addBoss(Boss boss)
        {
            Bosses.Add(boss);
        }
        */
    }
}
