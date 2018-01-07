using System;
using System.Collections.Generic;
using System.IO;
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
            IZAZIVAC, NAPADAC, ISCJELITELJ
        };

        public int battleLogID { get; set; }
        // String player;
        public Klasa? klasa { get; set; }
        public Role? role { get; set; }
        //tezina u dnevniku nije potrebna, ona se bazira na tezini boss-a
        public virtual RegisteredUser user { get; set; }
        public virtual Operation operation { get; set; }
        public virtual Boss boss { get; set; }

        public String log { get; set; }


        //public int ID { get; set; }
       // Role role { get; set; }
        //Difficulty difficulty { get; set; }
        //Boss boss { get; set; }
       // String player;
        //Klasa k;
        Dictionary<int, float> graphDPS = null;
        Dictionary<int, float> graphTPS = null;
        Dictionary<int, float> graphHPS = null;
        bool invalidInput = false;
        int time =0;
        public BattleLog(String path)
        {
            graphDPS = new Dictionary<int, float>();
            graphTPS = new Dictionary<int, float>();
            graphHPS = new Dictionary<int, float>();
            List<String> dnevnik = new List<String>();
            try
            {
                using (var reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        dnevnik.Add(reader.ReadLine());
                        invalidInput = false;
                    }
                }
                analizator(dnevnik);
            }catch(Exception e)
            {
                invalidInput = true;
            }
        }

        public List<String> getResult()
        {
            List <String> ret = new List<String>();
            if (invalidInput)
            {
                ret.Add("Invalid input!");
            }
            else
            {

                ret.Add(graphTPS[time].ToString());
                ret.Add(graphDPS[time].ToString());
                ret.Add(graphHPS[time].ToString());
            }
            return ret;
        }

        public void analizator(List<String> dnevnik)
        {

            bool first = true;
            int dps = 0;
            int tps = 0;
            int hps = 0;
            foreach (String x in dnevnik)
            {
                if (!first && !invalidInput)
                {
                    time = int.Parse(x.Split('|')[0].Split(':')[0]) * 60 + int.Parse(x.Split('|')[0].Split(':')[1]);
                    System.Console.WriteLine(time);
                    tps += int.Parse(x.Split('|')[2]);
                    dps += int.Parse(x.Split('|')[3]);
                    hps += int.Parse(x.Split('|')[4]);
                    graphTPS.Add(time, tps / time);
                    graphDPS.Add(time, dps / time);
                    graphHPS.Add(time, hps / time);
                }
                else
                {
                    first = false;
                }
                
            }
        }
    }
}
