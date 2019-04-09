using System;
using System.Collections.Generic;

namespace SP_FootballManager
{
    public class GetAllPlayersCommand : RequestCommand<List<Player>>
    {
        public GetAllPlayersCommand()
        {
        }

        public override List<Player> execute()
        {
            if (IsFileAvailalble(PLAYER_JSON_FILE))
            {
                return DeserializeObject(GetTextFromFile(PLAYER_JSON_FILE));
            }
            return new List<Player>();
        }
    }
}
