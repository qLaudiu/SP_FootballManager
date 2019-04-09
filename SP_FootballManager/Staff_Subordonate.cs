using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_FootballManager
{
    class Staff_Subordonate : IStaff
    {
        public override void Add(IStaff child)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(IStaff child)
        {
            throw new NotImplementedException();
        }

        protected internal override void Display(int depth)
        {
            base.DisplayIntern(depth);
        }
    }
}
