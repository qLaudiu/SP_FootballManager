using System;
namespace SP_FootballManager
{
    public class TeamDetailsCommand : RequestCommand<TeamDetails>
    {
        public TeamDetailsCommand()
        {
        }

        public override TeamDetails execute()
        {
            return DeserializeObject(GetTextFromFile(TEAM_DETAILS_FILE));
        }
    }
}
