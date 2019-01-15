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
    public partial class Speed : Form
    {

        public Int32 Checklanguage;

        public Speed()
        {
            InitializeComponent();
        }

        public void setLanguage(Int32 Checklanguage)
        {
            this.Checklanguage = Checklanguage;
        }

        private void btnCalculatePace_Click(object sender, EventArgs e)
        {
            double Stance = Convert.ToDouble(txtDistance.Text);
            string timeForLap = txtTime.Text;

            //convertToSeconds(timeForLap);
           double results = calcSpeed(Stance, timeForLap);

            txtResults.Text = Convert.ToString(results);
      



        }

        public double calcSpeed(double distance, string timeForLap)
        {
            double displacement = distance / 1000;
            double pace = 0;
            double time = TimeSpan.Parse(timeForLap).TotalHours;
            pace = (displacement / time);

        return pace;

        }

        //convert time
        public double convertToSeconds(String time)
        {
            double seconds = TimeSpan.Parse(time).TotalSeconds;
            return seconds;

        }

        private void btnResetPace_Click(object sender, EventArgs e)
        {
            txtDistance.Clear();
            txtResults.Clear();
            txtTime.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Calculation calc = new Calculation();
            calc.setLanguage(Checklanguage);
            calc.Show();
            this.Hide();
        }

        private void Speed_Load(object sender, EventArgs e)
        {
            Classes.LanguageSpeed speed = new Classes.LanguageSpeed();

            speed.setLingo(Checklanguage);

            lblDistance.Text = speed.getDistance();
            lblTime.Text = speed.gettime();
            btnCalculatePace.Text = speed.getCalculate();
            btnResetPace.Text = speed.getReset();
            buttonBack.Text = speed.getBack();
            txtTime.Clear();
        }
    }
}
