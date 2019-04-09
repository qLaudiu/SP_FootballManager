using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    class Staff : IStaff
    {
        private List<IStaff> children = new List<IStaff>();

        public Staff() : base()
        {
        }

        public override void Add(IStaff child)
        {
            if (!children.Contains(child))
            {
                children.Add(child);
            }
        }

        public override bool Remove(IStaff child)
        {
            if (!children.Contains(child))
            {
                children.Remove(child);
                return true;
            }
            else
            {
                return false;
            }
        }

        protected internal override void Display(int depth)
        {
            base.DisplayIntern(depth);
            depth++;
            foreach (IStaff child in children)
            {
                child.Display(depth);
            }
        }
    }
}
