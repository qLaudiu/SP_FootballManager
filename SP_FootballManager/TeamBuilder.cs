using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    class TeamBuilder
    {
        private Team team = new Team();

        public TeamBuilder()
        {

        }

        public void setTeam(List<Player> players)
        {
            team.Players = players;
        }
        
        //public void setStaff()
    }
}
