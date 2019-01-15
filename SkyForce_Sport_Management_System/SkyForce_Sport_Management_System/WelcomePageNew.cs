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
    public partial class WelcomePageNew : Form
    {
        public static WelcomePageNew mdi;
        public WelcomePageNew()
        {
            InitializeComponent();
            
        }

        private void WelcomePageNew_Load(object sender, EventArgs e)
        {
            button4.Enabled = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Athlete().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Coach().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you wa'nt to cancel?");
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
