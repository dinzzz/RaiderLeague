using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaiderLeague.Models
{
    public class Operation
    {

        int operationID;
        String operationName { get; set; }
        List<Boss> bosses { get; }
        Difficulty difficulty { get; set; } // dodati ovo u dijagram klasa

        public Operation(String operationName)
        {
            this.operationName = operationName;
        }

        public Boss getSpecificBoss(int index)
        {
            return bosses.ElementAt(index);
        }

        public void addBoss(Boss boss)
        {
            bosses.Add(boss);
        }

    }
}
