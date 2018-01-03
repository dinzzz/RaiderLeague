using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaiderLeague.Models
{
    public class Boss
    {

        public int ID { get; set; } 
        public String bossName { get; set; }
        public int health { get; set; } //popraviti geter u dijagramu klasa
        public int damage { get; set; }
        public int operationID;
        Difficulty difficulty { get; set; } // dodati u dijagram klasa

        /*public Boss(String bossName, int damage, int health, Difficulty difficulty, int operationID)
        {
            this.bossName = bossName;
            this.damage = damage;
            this.health = health;
            this.difficulty = difficulty;
            this.operationID = operationID;
        }*/

    }
}
