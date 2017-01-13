using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindForms
{
    class Party
    {
        private List<Player> Members;
        private Player currentPlayer;

        public Party(Player a, Player b, Player c)
        {
            Members.Add(a);
            Members.Add(b);
            Members.Add(c);
            currentPlayer = a;
        }
        public Player GetNext()
        {
            if (currentPlayer.EndPlayerTurn)
        }
    }
}