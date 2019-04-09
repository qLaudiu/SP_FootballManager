using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    class P_GoalKeeper : IPosition
    {
        private Role? player_role;

        public string Player_notes { get; set; }
        public Role? Player_role
        {
            get
            {
                if (player_role == null)
                {
                    throw new Exception(" GK value role not set");
                }
                return player_role;
            }
            set
            {
                if (Role.GK == value)
                {
                    player_role = value;
                }
                else
                {
                    throw new Exception(" GK value type can not be set");
                }
            }
        }

        public P_GoalKeeper(Role type)
        {
            Player_role = type;
        }

        public override string ToString()
        {
            return "GK: " + player_role;
        }
    }
}
