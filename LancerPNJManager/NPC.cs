using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancerPNJManager
{
    class NPC
    {

        public string Name { get; set; }
        public Stats StatsT1 { get; set; }
        public Stats StatsT2 { get; set; }
        public Stats StatsT3 { get; set; }

        public override string ToString()
        {
            string s = "Nom : " + this.Name + "\n";
            s += "  Tier 1 : \n";
            s += this.StatsToString(StatsT1);
            s += "\n Tier 2 : \n";
            s += this.StatsToString(StatsT2);
            s += "\n Tier 3 : \n";
            s += this.StatsToString(StatsT3);

            return s;
        }

        public string StatsToString(Stats _stat)
        {
            string s = "HP : " + _stat.hp + "\n";
            s += "Evade : " + _stat.evade + "\n";
            s += "E-Defense : " + _stat.edefense + "\n";
            s += "Heat : " + _stat.heat + "\n";
            s += "Hull : " + _stat.hull + "\n";
            s += "Agi : " + _stat.agi + "\n";
            s += "Sys : " + _stat.sys + "\n";
            s += "Eng : " + _stat.eng + "\n";
            s += "Armor : " + _stat.armor + "\n";
            s += "Speed : " + _stat.speed + "\n";
            s += "Sense : " + _stat.sense + "\n";
            s += "Save : " + _stat.save + "\n";
            s += "Size : " + _stat.size + "\n";

            return s;
        }

    }
    struct Stats
    {
       public int hp;
       public int evade;
       public int edefense;
       public int heat;
       public int hull;
       public int agi;
       public int sys;
       public int eng;
       public int armor;
       public int speed;
       public int sense;
       public int save;
       public int size;
    }
}
