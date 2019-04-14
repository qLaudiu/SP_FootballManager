using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    class TacticBuildDirector
    {
        TacticBuilder tacticBuilder;
        public TacticBuildDirector()
        {
            tacticBuilder = new TacticBuilder();
        }

        public Tactic GetTactic(EFormation eFormation, List<Player> PlayerList)
        {
            tacticBuilder.setFormation(eFormation);
            tacticBuilder.unsetRoster();
            tacticBuilder.setRoster(PlayerList);
            tacticBuilder.setUpTeam();
            return tacticBuilder.tactic;
        }

    }
}
