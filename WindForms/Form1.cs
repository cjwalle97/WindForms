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
        Player Knight;
        Player Wizard;
        Player Priest;
        Player Samurai;
        Player Shaman;
        Player Cleric;
        Party Friend;
        Party Foe;
        public Form1()
        {
            InitializeComponent();
            Knight = new Player(1, 0, 100);
            Wizard = new Player(1, 0, 80);
            Priest = new Player(1, 0, 60);
            Samurai = new Player(1, 0, 100);
            Shaman = new Player(1, 0, 80);
            Cleric = new Player(1, 0, 60);
            Friend = new Party(Knight, Wizard, Priest);
            Foe = new Party(Samurai, Shaman, Cleric);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.LevelUp();
            if(progressBar1.Value != 100)
            {
                textBox1.Text = null;
            }

            if (progressBar1.Value < 100)
            {
                if (progressBar1.Value < 60)
                {
                    progressBar1.Value += 10;
                    Knight.EXP += 10;
                }
                if (progressBar1.Value >= 60)
                {
                    progressBar1.Value += 5;
                    Knight.EXP += 5;
                }
            }
            if (progressBar1.Value == 100)
            {

                textBox1.Text = "LEVEL UP";
                progressBar1.Value -= 100;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
