using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KamakNojicaHartiq
{
    public partial class Form1 : Form
    {
        int playersel;
        int player = 0;
        int pc = 0;
        int pcsel;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            playersel = 3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            playersel = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Random r = new Random();
            pcsel = r.Next(1,4);
            if (pcsel == 1)
            {
                if (playersel ==1)
                {
                    label1.Text = "PC picked Rock, Draw";
                }
                if (playersel == 2)
                {
                    label1.Text = "PC picked Rock, Player WINS!";
                    player = player += 1;
                    
                }
                if (playersel == 3)
                {
                    label1.Text = "PC picked Rock, PC WINS!";
                    pc = pc +=1;
                    
                }
                label2.Text = "PC: " + pc;
                label3.Text = "Player: " + player;
            }
            else if (pcsel == 2)
            {
                if (playersel == 1)
                {
                    label1.Text = "PC picked Paper, PC WINS!";
                    pc = pc +=1;
                    
                }
                if (playersel == 2)
                {
                    label1.Text = "PC picked Paper, Draw!";
                    
                }
                if (playersel == 3)
                {
                    label1.Text = "PC picked Paper, Player WINS!";
                    player = player +=1;
                    
                }
                label3.Text = "Player: " + player;
                label2.Text = "PC: " + pc;
            }
            else if (pcsel == 3)
            {
                if (playersel == 1)
                {
                    label1.Text = "PC picked Scissors, Player WINS!";
                    player = player +=1;
                    
                }
                if (playersel == 2)
                {
                    label1.Text = "PC picked Scissors, PC WINS!";
                    pc = pc +=1;
                    
                }
                if (playersel == 3)
                {
                    label1.Text = "PC picked Scissors, DRAW!";
                    
                }
                label3.Text = "Player: " + player;
                label2.Text = "PC: " + pc;
            }
            if (player >= 10)
            {
                MessageBox.Show("Player Wins!");
                pc = 0;
                player = 0;
                label3.Text = "Player: " + player;
                label2.Text = "PC: " + pc;
            }
            if (pc >= 10)
            {
                MessageBox.Show("PC Wins!");
                pc = 0;
                player = 0;
                label3.Text = "Player: " + player;
                label2.Text = "PC: " + pc;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            playersel = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "PC: 0";
            label3.Text = "Player: 0";

        }
    }
}
