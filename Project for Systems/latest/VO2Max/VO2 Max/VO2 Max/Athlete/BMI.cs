using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VO2_Max.Athlete
{
    public partial class BMI : Form
    {
        public Int32 Checklanguage;

        public BMI()
        {
            InitializeComponent();
        }


        public void setLanguage(Int32 Checklanguage)
        {
            this.Checklanguage = Checklanguage;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(txtHeight.Text);
            double Weight = Convert.ToDouble(txtWeight.Text);

            string measurement = ComboMeasurement.SelectedItem.ToString();

            double results = BMICalculate(measurement, Weight, height);
            txtResultBMI.AppendText(Convert.ToString(results));

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void BMI_Load(object sender, EventArgs e)
        {
            Classes.LanguageBMI myLingo = new Classes.LanguageBMI();

            myLingo.setLingo(Checklanguage);

            labelTitle.Text = myLingo.getTitle();
            radioButtonAdult.Text = myLingo.getAdult();
            radioButtonChild.Text = myLingo.getChildren();
            lblCalculate.Text = myLingo.getCalcFor();
            btnCalculate.Text = myLingo.getCalcFor();
            btnResetBMI.Text = myLingo.getReset();
           // lblFeet.Text = myLingo.getMetre();
            lblHeight.Text = myLingo.getHeight();
            lblWeight.Text = myLingo.getWeight();
            buttonBack.Text = myLingo.getBack();
            lblPounts.Text = myLingo.getKG();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Calculation calc = new Calculation();
            calc.setLanguage(Checklanguage);
            calc.Show();
            this.Hide();
        }
        public double BMICalculate(string measurement, double weight, double height)
        {
            double BMI = 0;
            double ConvertedMeasurement = 0;
            //convert height to meter
            if (measurement.Equals("Cm"))
            {
                ConvertedMeasurement = height / 100;
                BMI = (weight / (ConvertedMeasurement * ConvertedMeasurement));
            }
            else if (measurement.Equals("M"))
            {
                BMI = (weight / (height * height));
            }
            else
            {
                ConvertedMeasurement = height * 0.3048;
                BMI = (weight / (ConvertedMeasurement * ConvertedMeasurement));
            }
            return BMI;
        }

        private void btnResetBMI_Click(object sender, EventArgs e)
        {
            txtHeight.Clear();
            txtWeight.Clear();
            txtResultBMI.Clear();
        }
    }
}
