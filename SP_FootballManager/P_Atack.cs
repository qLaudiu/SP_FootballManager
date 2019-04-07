using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    class P_Atack : IPosition
    {
        public string Player_notes { get; set; }

        public Role? Player_role
        {
            get
            {
                if (Player_role == null)
                {
                    throw new Exception(" ATK value role not set");
                }
                return Player_role;
            }
            set
            {
                if (Role.SS == value || Role.CF == value)
                {
                    Player_role = value;
                }
                else
                {
                    throw new Exception(" ATK value type can not be set");
                }
            }
        }

        public P_Atack()
        {
            Player_role = null;
        }
    }
}
