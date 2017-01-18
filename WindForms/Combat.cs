using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindForms
{
    /// <summary>
    /// this is the combat functon, it is used to cycle the turns of all the Players in both Parties
    /// </summary>
    class Combat
    {
        private List<Party> Parties;
        private Party currentParty;
        private Player currentPlayer;

        public Combat(Party a, Party b)
        {
            Parties.Add(a);
            Parties.Add(b);
            currentParty = a;
        }
        //Name: TurnOrder
        //Type: Void
        //Description: to determine who the Current Player is and then move on to the next Player or Party
        public Party GetNextParty()
        {
            
        }
    }
}
