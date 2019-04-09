using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    abstract class IStaff
    {
        public Staff_Type type { get; set; }
        public string notes { get; set; }

        public abstract void Add(IStaff child);
        public abstract bool Remove(IStaff child);
        protected internal abstract void Display(int depth);

        protected void DisplayIntern(int depth)
        {
            Console.WriteLine(new String ('|', depth+1) + "- Type: " + type + " Notes: " + notes);
        }
    }
}
