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
    public partial class VO2Max : Form
    {
        private int sqlage, count, gender;
        private double sqlHeight, sqlWeight, results;

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Athlete().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtResults_TextChanged(object sender, EventArgs e)
        {

        }

        public VO2Max()
        {
            InitializeComponent();
        }

        private void VO2Max_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            txtHeight.Text = Convert.ToString(sqlHeight);
            txtWeight.Text = Convert.ToString(sqlWeight);
            txtAge.Text = Convert.ToString(sqlage);
            if (comboGender.SelectedItem.ToString() == "Male")
            {
                gender = 1;
            }
            else { gender = 0; }
            double VO2Max = 132.853 - (0.0769 * sqlWeight) - (0.3877 * sqlage) + (6.315 * gender) - (0.1565 * 150);
            txtResults.Text = VO2Max.ToString();
        }
    }
}
