using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    public interface IPosition
    {
        String Player_notes { get; set; }
        Role? Player_role { get; set; }
    }
}
