using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    class Team_Iterator : Team_Selector
    {
        private int current_index = -1;

        public Team_Iterator(Team team) : base(team)
        {
        }

        public Player Next()
        {
            try
            {
                ++current_index;
                return base.selected[current_index];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Player Pervous()
        {
            try
            {
                --current_index;
                return base.selected[current_index];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void Reset()
        {
            current_index = 0;
        }

        public Player GetByIndex(int index)
        {
            try
            {
                return base.selected[index];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool IsValid()
        {
            if (base.selected.Count > current_index && -1 > current_index)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
