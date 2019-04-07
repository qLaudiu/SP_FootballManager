using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    class P_Deffender : IPosition
    {
        public string Player_notes { get; set; }

        public Role? Player_role
        {
            get
            {
                if (Player_role == null)
                {
                    throw new Exception(" DEF value role not set");
                }
                return Player_role;
            }
            set
            {
                if (Role.CB == value || Role.LB == value || Role.RB == value)
                {
                    Player_role = value;
                }
                else
                {
                    throw new Exception(" DEF value type can not be set");
                }
            }
        }

        public P_Deffender()
        {
            Player_role = null;
        }
    }
}
