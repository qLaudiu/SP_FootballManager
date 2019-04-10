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
        public long Budget { get; set; }
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
            var s1 = string.Format("[Team: Budget={0}, Clasament_Position={1}, Name={2}, Shor_Name={3}, Year={4}]", Budget, Clasament_Position, Name, Shor_Name, Year);

            var s2 = "";
            foreach (Player p in Players)
            {
                s2 = s2 + p + "\n";
            }

            Staff.Display(0);

            return s1 + "\n" + s2 + "\n";
        }


        public void ChangeTactic(EFormation eFormation)
        {
            TacticBuildDirector tacticBuildDirector = new TacticBuildDirector();
            BestTactic = tacticBuildDirector.GetTactic(eFormation, this.Players);
        
        }
    }
}
