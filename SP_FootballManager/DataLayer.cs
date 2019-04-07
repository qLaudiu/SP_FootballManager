using System;
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
    }
}
