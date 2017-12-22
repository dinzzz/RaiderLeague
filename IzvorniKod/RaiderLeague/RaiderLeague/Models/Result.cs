using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RaiderLeague.Models
{
    public class Result
    {
        int resultID;
        float HPS;
        float TPS;
        float DPS;

        public void calculateResult()
        {
        }
        // popraviti -- File ne moze biti parametar
        // i difficulty se ne moze procitat
        public void result(File log, Difficulty t)
        {
        }

        public String getStatistics()
        {
        }
    }
}
