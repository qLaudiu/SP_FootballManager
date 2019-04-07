using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    class P_GoalKeeper : IPosition
    {
        public string Player_notes { get; set; }

        public Role? Player_role
        {
            get
            {
                if (Player_role == null)
                {
                    throw new Exception(" GK value role not set");
                }
                return Player_role;
            }
            set
            {
                if (Role.GK == value)
                {
                    Player_role = value;
                }
                else
                {
                    throw new Exception(" GK value type can not be set");
                }
            }
        }

        public P_GoalKeeper()
        {
            Player_role = null;
        }
    }
}
