using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    class Tactic
    {
        
        public Player Gk { get; set; }
        public List<Player> Def { get; set; }
        public List<Player> Mid { get; set; }
        public List<Player> Atk { get; set; }
        public List<Player> Substitutes { get; set; }
        public EFormation formation { get; set; }

        public Tactic()
        {
            Gk = new Player();
            Def = new List<Player>();
            Mid = new List<Player>();
            Atk = new List<Player>();
            Substitutes = new List<Player>();
        }

        public override string ToString()
        {
            var gk = "GK: " + Gk;

            var def = "DEF PLAYERS: \n";
            foreach (Player p in Def)
            {
                def = def + p + "\n";
            }

            var mid = "MID PLAYERS: \n";
            foreach (Player p in Mid)
            {
                mid = mid + p + "\n";
            }

            var atk = "ATK PLAYERS: \n";
            foreach (Player p in Atk)
            {
                atk = atk + p + "\n";
            }

            var sub = "SUBS PLAYERS: \n";
            foreach (Player p in Substitutes)
            {
                sub = sub + p + "\n";
            }

            return "TEAM TACKTIC: \n FORMATION: " + formation + "\n" + gk + "\n" + def + mid + atk;
        }
    }
}
