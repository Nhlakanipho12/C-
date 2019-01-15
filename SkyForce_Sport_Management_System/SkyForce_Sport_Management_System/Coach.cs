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
    public partial class Coach : Form
    {
        public Coach()
        {
            InitializeComponent();
        }

        private void btbManageAthlete_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new EditAthlete().Show();
        }

        private void btbTounament_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new SportPage().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new WelcomePageNew().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you wa'nt to cancel?");
            Application.Exit();
        }

        private void btbAnnouncement_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new TournamentDetails().Show();
        }
    }
}
