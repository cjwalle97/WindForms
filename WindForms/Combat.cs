using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindForms
{
    class Combat
    {
        private List<Party> ActiveSides;

        public Combat(Party a, Party b)
        {
            ActiveSides.Add(a);
            ActiveSides.Add(b);
        }
    }
}
