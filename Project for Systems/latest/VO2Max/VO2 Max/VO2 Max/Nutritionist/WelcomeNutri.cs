﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VO2_Max.Nutritionist
{
    public partial class ViewDiet : Form
    {
        public ViewDiet()
        {
            InitializeComponent();
        }

        private void ViewDiet_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Athlete.Calculation calc = new Athlete.Calculation();
            //calc.setLanguage(Checklanguage);
            calc.Show();
            this.Hide();
        }
    }
}
