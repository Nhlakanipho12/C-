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
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void radioButton2Child_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1Adult_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Athlete().Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you wa'nt to cancel?");
            Application.Exit();
        }
    }
}
