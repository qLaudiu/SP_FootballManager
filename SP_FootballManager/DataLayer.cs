using System;
using System.Collections.Generic;

namespace SP_FootballManager
{
    public class DataLayer
    {

        private static DataLayer instance;

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

        public List<Player> GetAllPlayers()
        {
            return null;
        }

        public Player GetPlayerById(string id)
        {
            return null;
        }

        public bool AddPlayer(Player player)
        {
            return false;
        }

        public string GetTeamName()
        {
            return null;
        }

        public string GetTeamShortName()
        {
            return null;
        }

        public string GetTeamClasamentPosition()
        {
            return null;
        }

        public string GetTeamFoundationYear()
        {
            return null;
        }

        public string GetTeamBudget()
        {
            return null;
        }
    }
}
