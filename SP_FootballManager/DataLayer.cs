using System;
using System.Collections.Generic;

namespace SP_FootballManager
{
    public class DataLayer
    {

        /*
            DataLayer dataLayer = DataLayer.GetInstance();

            Console.WriteLine(dataLayer.GetTeamName());
            Console.WriteLine(dataLayer.GetTeamShortName());
            Console.WriteLine(dataLayer.GetTeamFoundationYear());
            Console.WriteLine(dataLayer.GetTeamClasamentPosition());
            Console.WriteLine(dataLayer.GetTeamFoundationYear());
            Console.WriteLine(dataLayer.GetTeamBudget());

            foreach (Player p in dataLayer.GetAllPlayers())
            {
                Console.WriteLine(p);
            }

            Player player = new Player(2222);
            player.Age = 10;
            player.Name = "Vasile";
            dataLayer.AddPlayer(player);*/

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

        public IStaff GetStuff()
        {
            return null;
        }

        public List<Player> GetAllPlayers()
        {
            return new GetAllPlayersCommand().execute();
        }

        public bool AddPlayer(Player player)
        {
            return new AddPlayerCommand(player).execute();
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
