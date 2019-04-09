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
        
        public void setYear(int year)
        {
            team.Year = year;
        }

        public void setName(string name)
        {
            team.Name = name;
        }
        public void setClassmentPosition(int position)
        {
            team.Clasament_Position = position;
        }

        public void setShorName(string shorName)
        {
            team.Shor_Name = shorName;
        }

        public void setBudget(int budget)
        {
            team.Budget = budget;
        }

        public void setStaffMembers(Staff_Members staff_Members)
        {
            team.Staff = staff_Members;
        }
    }
}
