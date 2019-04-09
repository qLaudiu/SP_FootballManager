using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    class P_Deffender : IPosition
    {
        private Role? player_role;
        
        public string Player_notes { get; set; }
        public Role? Player_role
        {
            get
            {
                if (player_role == null)
                {
                    throw new Exception(" DEF value role not set");
                }
                return player_role;
            }
            set
            {
                if (Role.CB == value || Role.LB == value || Role.RB == value)
                {
                    player_role = value;
                }
                else
                {
                    throw new Exception(" DEF value type can not be set");
                }
            }
        }

        public P_Deffender(Role type)
        {
            Player_role = type;
        }

        public override string ToString()
        {
            return "DEF: " + player_role;
        }
    }
}
