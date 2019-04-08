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

        public TacticBuildDirector(EFormation eFormation,List<Player> PlayerList)
        {
            if(tacticBuilder==null)
            {
                tacticBuilder = new TacticBuilder();
            }
            tacticBuilder.setFormation(eFormation);
            tacticBuilder.setRoster(PlayerList);
        }

    }
}
