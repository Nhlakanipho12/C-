using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyForce_Sport_Management_System
{
    public partial class SportPage : Form
    {
        public SportPage()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you wa'nt to cancel?");
            Application.Exit();
        }

        private void soccerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new BasketBall().Show();
        }

        private void playersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Rugby().Show();
        }

        private void playersToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            new SoccerPlayers().Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Athlete().Show();
        }

        private void tournamentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new SoccerTournament().Show();


    }
    }
}
