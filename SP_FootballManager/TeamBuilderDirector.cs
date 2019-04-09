using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    class TeamBuilderDirector
    {
        TeamBuilder teamBuilder = new TeamBuilder();

        DataLayer dataLayer = DataLayer.GetInstance();

        public TeamBuilderDirector()
        {
            
        }


        public Team GetTeam()
        {
            teamBuilder.setTeam(dataLayer.GetAllPlayers());
            teamBuilder.setYear(dataLayer.GetTeamFoundationYear());
            teamBuilder.setStaffMembers(dataLayer.GetStuff());
            teamBuilder.setShorName(dataLayer.GetTeamShortName());
            teamBuilder.setName(dataLayer.GetTeamName());
            teamBuilder.setBudget(dataLayer.GetTeamBudget());
            teamBuilder.setClassmentPosition(dataLayer.GetTeamClasamentPosition());
            return teamBuilder.team;
        }



    }
}
