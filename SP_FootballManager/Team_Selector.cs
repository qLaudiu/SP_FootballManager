using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    class Team_Selector
    {
        private Team team;
        private Role? type = null;
        protected List<Player> selected = new List<Player>();

        public Team_Selector(Team team)
        {
            this.team = team;
            selected = new List<Player>(team.Players);
        }

        public void SetRole(Role type)
        {
            this.type = type;
            selected = new List<Player>(team.Players.Where((item, index) => item.Position.Player_role == this.type));
        }
    }
}
