using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Poker_Repo
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int Index;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
        }
            private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switchPanel();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            switchPanel();
        }

        private void switchPanel()
        {
            if (Index < listPanel.Count - 1)
            {
                Index++; 
            }
            else if (Index > 0)
            {
                Index--;
            }
            listPanel[Index].BringToFront();
        }
    }
}
