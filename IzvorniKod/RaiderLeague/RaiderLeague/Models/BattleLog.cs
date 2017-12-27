using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaiderLeague.Models
{
    public enum Difficulty
    {
        LAGANO, UMJERENO, TESKO
    };
    public class BattleLog
    {

        // u dijagramu klasa ima setName ????

        public enum Role
        {
            IZAZIVAC, NAPADAC, ISJELITELJ
        };

        String log;
        int battleLogID;
        Role role { get; set; }
        Difficulty difficulty { get; set; }
        Boss boss { get; set; }
        String player;
        Klasa k;


        // opet u dijagramu klasa File u konstruktoru
        public BattleLog (Difficulty t, String log,Boss b,Klasa k)
        {
            this.boss = b;
            this.difficulty = t;
            this.log = log;
            this.k = k;
        }

    }
}
