using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaiderLeague.Models
{
    public class Boss
    {

        public int BossID { get; set; }
        public String BossName { get; set; }
        public int Health { get; set; } //popraviti geter u dijagramu klasa
        public int Damage { get; set; }
        public Difficulty? Difficulty { get; set; } // dodati u dijagram klasa

        public virtual Operation Operation { get; set; }
        public virtual ICollection<BattleLog> BattleLog { get; set; }






        //izbaciti IDoperacije iz dokumentacije

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
