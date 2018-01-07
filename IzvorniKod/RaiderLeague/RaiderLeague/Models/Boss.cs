using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaiderLeague.Models
{
    public class Boss
    {

        public int ID { get; set; }
        public String BossName { get; set; }
        public int Health { get; set; } //popraviti geter u dijagramu klasa
        public int Damage { get; set; }
        public Difficulty? Difficulty { get; set; } // dodati u dijagram klasa

        public virtual Operation Operation { get; set; }
        public virtual ICollection<BattleLog> BattleLog { get; set; }


        /*
        public Boss(String bossName, int damage, int health)
        {
            this.BossName = bossName;
            this.Damage = damage;
            this.Health = health;
            this.Difficulty = null;
            this.Operation = null;
        }
        */
    }
}
