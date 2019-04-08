using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    abstract class IStaff
    {
        Staff_Type type { get; set; }
        string notes { get; set; }

        public abstract void Add(IStaff child);
        public abstract bool Remove(IStaff child);
        protected internal abstract void Display(int depth);
    }
}
