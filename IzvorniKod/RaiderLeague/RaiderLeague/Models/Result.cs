using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RaiderLeague.Models
{
    public class Result
    {
        public int ID { get; set; }
        public float HPS;
        public float TPS;
        public float DPS;

        public virtual BattleLog BattleLog { get; set; }

        public void calculateResult()
        {
        }
        // popraviti -- File ne moze biti parametar
        // i difficulty se ne moze procitat
       /* public void result(String log, Difficulty t)
        {
        }*/

        public String getStatistics()
        {
            return "";
        }
    }
}
