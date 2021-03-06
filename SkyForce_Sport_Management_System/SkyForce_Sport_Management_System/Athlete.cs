﻿using System;
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
    public partial class Athlete : Form
    {
        public Athlete()
        {
            InitializeComponent();
        }

        private void Athlete_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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

        private void button4View_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new SportPage().Show();
        }

        private void button5CalBMI_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new BMI().Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new UpdateAthleteInfo().Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new VO2Max().Show();
        }
    }
}
