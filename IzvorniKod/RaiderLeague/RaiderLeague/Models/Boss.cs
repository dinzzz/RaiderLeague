using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaiderLeague.Models
{
    public class Boss
    {

        int bossId;
        String bossName { get; set; }
        int health { get; set; } //popraviti geter u dijagramu klasa
        int damage { get; set; }
        int operationID;
        Difficulty difficulty { get; set; } // dodati u dijagram klasa

        public Boss(String bossName, int damage, int health, Difficulty difficulty, int operationID)
        {
            this.bossName = bossName;
            this.damage = damage;
            this.health = health;
            this.difficulty = difficulty;
            this.operationID = operationID;
        }

    }
}
