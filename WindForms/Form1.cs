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

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           if(progressBar1.Value != 100)
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
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
