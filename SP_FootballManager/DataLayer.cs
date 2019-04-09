using System;
using System.Collections.Generic;

namespace SP_FootballManager
{
    public class DataLayer
    {
        private static DataLayer instance;

        private IPlayersListener iPlayersListener;

        public void SetIPlayerListener(IPlayersListener iPlayersListener)
        {
            this.iPlayersListener = iPlayersListener;
        }

        public static DataLayer GetInstance() 
        {
            if (instance == null)
            {
                instance = new DataLayer();
            }
            return instance;
        }

        private DataLayer()
        {
            // Private constructor
        }

        public Staff_Members GetStaff()
        {
            return new GetStaffCommand().execute();
        }

        public List<Player> GetAllPlayers()
        {
            return new GetAllPlayersCommand().execute();
        }

        public bool AddPlayer(Player player)
        {
            var result = new AddPlayerCommand(player).execute();
            if (result && iPlayersListener != null)
            {
                iPlayersListener.OnPlayerModified();
            }
            return result;
        }

        public string GetTeamName()
        {
            return new TeamDetailsCommand().execute().TeamName;
        }

        public string GetTeamShortName()
        {
            return new TeamDetailsCommand().execute().TeamShortName;
        }

        public int GetTeamClasamentPosition()
        {
            return new TeamDetailsCommand().execute().TeamClasamentPosition;
        }

        public int GetTeamFoundationYear()
        {
            return new TeamDetailsCommand().execute().TeamFoundationYear;
        }

        public long GetTeamBudget()
        {
            return new TeamDetailsCommand().execute().TeamBudget;
        }
    }
}
