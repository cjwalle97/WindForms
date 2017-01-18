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
        public Player GetNextPlayer(Player.EndPlayerTurn nextplayer)
        {
            Player NewPlayer = currentPlayer;
            for (int i = 0; Members[i] != currentPlayer; i++)
            {
                if (Members[i] == currentPlayer)
                {
                    currentPlayer = Members[i + 1];
                }
            }
            return NewPlayer;
        }
    }
}