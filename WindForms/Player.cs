using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindForms
{
    class Player
    {
        private int m_level;
        private int m_experience;
        //private int m_health;
        //private int m_mana;
        //private int m_strength;
        //private int m_magic;
        //private int m_dexterity;
        //private int m_agility;
        //private int m_resilience;

        public Player(int l, int e /*int h, int m, int s, int b, int d, int a, int r*/ )
        {
            m_level = l; m_experience = e; /*m_health = h; m_mana = m; m_strength = s;
                m_magic = b; m_dexterity = d; m_agility = a; m_resilience = r;*/

        }
        public int Level
        {
            get
            {
                return m_level;
            }
            set
            {
                m_level = 1;
            }
        }
        public int EXP
        {
            get
            {
                return m_experience;
            }
            set
            {
                m_experience = 0;
            }
        }

        //public int HP;
        //public int MP;
        //public int STR;
        //public int MAG;
        //public int DEX;
        //public int AGI;
        //public int RES;

        //Name: LevelUp
        //Type: int
        //Description: increment the players level when their experience reaches a certain threshold
        public int LevelUp()
        {
            int NeededExp = 100;
            if (m_level > 1)
            {
                NeededExp = 100 * (m_level * 2);
            }
            if (m_experience == NeededExp)
            {
                m_level += 1;
            }
            return m_level;
        }
        public Player Chris(1, 0);
    }
  
}
