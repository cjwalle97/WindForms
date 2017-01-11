using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Player
        {
            private int m_level;
            //private int m_health;
            //private int m_mana;
            //private int m_strength;
            //private int m_magic;
            //private int m_dexterity;
            //private int m_agility;
            //private int m_resilience;
            private int m_experience;

            public Player (int l, int e /*int h, int m, int s, int b, int d, int a, int r*/ )
            {
                m_level = l; m_experience = e; /*m_health = h; m_mana = m; m_strength = s;
                m_magic = b; m_dexterity = d; m_agility = a; m_resilience = r;*/

            }
            public int Level;
            public int HP;
            public int MP;
            public int STR;
            public int MAG;
            public int DEX;
            public int AGI;
            public int RES;
            public int EXP;
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
                if(m_experience == NeededExp)
                {
                    m_level += 1;
                }
                return m_level;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                textBox1.Text = "LEVEL UP";
                progressBar1.Value -= 100;
            }
            if (progressBar1.Value < 100)
            {
                if (progressBar1.Value < 60)
                {
                    progressBar1.Value += 10;
                }
                if (progressBar1.Value >= 60)
                {
                    progressBar1.Value += 5;
                }
            }
        }

    }
}
