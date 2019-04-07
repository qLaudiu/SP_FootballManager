﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    class P_Middle : IPosition
    {
        public string Player_notes { get; set; }

        public Role? Player_role
        {
            get
            {
                if (Player_role == null)
                {
                    throw new Exception(" MID value role not set");
                }
                return Player_role;
            }
            set
            {
                if (Role.CM == value || Role.LM == value || Role.RM == value || Role.CDM == value)
                {
                    Player_role = value;
                }
                else
                {
                    throw new Exception(" MID value type can not be set");
                }
            }
        }

        public P_Middle()
        {
            Player_role = null;
        }
    }
}