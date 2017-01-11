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

        //class Player
        //{
        //    private int m_level;
        //    private int m_health;
        //    private int m_mana;
        //    private int m_strength;
        //    private int m_magic;
        //    private int m_dexterity;
        //    private int m_agility;
        //    private int m_resilience;

        //    public Player (int l, int h, int m, int s, int b, int d, int a, int r)
        //    {
        //        m_level = l; m_health = h; m_mana = m; m_strength = s;
        //        m_magic = b; m_dexterity = d; m_agility = a; m_resilience = r;
        //    }
        //    public int Level;
        //    public int HP;
        //    public int MP;
        //    public int STR;
        //    public int MAG;
        //    public int DEX;
        //    public int AGI;
        //    public int RES;
        //    public Player LevelUp()
        //    {
        //        return Player 
        //    }
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
