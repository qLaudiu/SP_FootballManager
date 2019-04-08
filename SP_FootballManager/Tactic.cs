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

    }
}
