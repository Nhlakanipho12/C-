using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VO2_Max.Athlete
{
    public partial class Calculation : Form
    {
      

        public Int32 Checklanguage;
        public string name,athlete;


        public Calculation()
        {
            InitializeComponent();
        }


        public void setLanguage(Int32 Checklanguage)
        {
            this.Checklanguage = Checklanguage;
        }

        public void setUser(string name)
        {
            this.name = name ;
        }

        private void buttonBMI_Click(object sender, EventArgs e)
        {
            BMI myB = new BMI();
            myB.setLanguage(Checklanguage);
            myB.setUser(name);
            myB.setAthlete(athlete);
            myB.Show();
            this.Hide();
        }

        private void buttonHeartRate_Click(object sender, EventArgs e)
        {
            HeartRate Hrate = new HeartRate();
            Hrate.setLanguage(Checklanguage);
            Hrate.setUser(name);
            Hrate.setAthlete(athlete);
            Hrate.Show();
            this.Hide();
        }

        private void buttonVOMax_Click(object sender, EventArgs e)
        {
            vomax max = new vomax();
            max.setLanguage(Checklanguage);
            max.setUser(name);
            max.setAthlete(athlete);
            max.Show();
            this.Hide();
        }

        private void buttonSpeed_Click(object sender, EventArgs e)
        {
            Speed sp = new Speed();
            sp.setLanguage(Checklanguage);
            sp.setUser(name);
            sp.setAthlete(athlete);
            sp.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

            SignIn sign = new SignIn();
            sign.setLanguage(Checklanguage);
            sign.Show();
            this.Hide();

        }

        private void Calculation_Load(object sender, EventArgs e)
        {
            Language.LanguageCalculation myLingo = new Language.LanguageCalculation();

            myLingo.setLingo(Checklanguage);

            buttonBMI.Text = myLingo.getBMI();
            buttonDiet.Text = myLingo.getBodyFat();
            buttonHeartRate.Text = myLingo.getHeartRate();
            buttonSpeed.Text = myLingo.getSpeed();
            buttonLogout.Text = myLingo.getUitgaan();
            labelUsername.Text = name;
            

        }

        public void setAthlete(string athlete)
        {
            this.athlete = athlete;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDiet_Click(object sender, EventArgs e)
        {
            Nutritionist.ViewDiet Diet = new Nutritionist.ViewDiet();
            Diet.setLanguage(Checklanguage);
            Diet.setUser(name);
            Diet.Show();
            this.Hide();
        }
    }
}
