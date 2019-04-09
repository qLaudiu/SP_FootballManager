using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    class Team
    {
        public List<Player> Players = new List<Player>();
        public Tactic BestTactic = new Tactic();
        public Staff_Members Staff = new Staff_Members();
        public int Budget { get; set; }
        public int Clasament_Position { get; set; }
        public string Name { get; set; }
        public string Shor_Name { get; set; }
        public int Year { get; set; }

        public Team()
        {
            
        }

        public Team(Team team)
        {
            Players = team.Players;
            Staff = team.Staff;
            Budget = team.Budget;
            Clasament_Position = team.Clasament_Position;
            Name = team.Name;
            Shor_Name = team.Shor_Name;
            Year = team.Year;
        }

        public override string ToString()
        {
            // TODO: finish
            return "Players: " + Players;
        }


        public void ChangeTactic(EFormation eFormation)
        {
            TacticBuildDirector tacticBuildDirector = new TacticBuildDirector();
            BestTactic = tacticBuildDirector.GetTactic(eFormation, this.Players);
        
        }
    }
}
