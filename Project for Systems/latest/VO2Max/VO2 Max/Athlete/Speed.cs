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
    public partial class Speed : Form
    {
        MySqlConnection connect;
     
        String connectionStr = "server=localhost;user id=root;database=fitness";
        private string  WQuery;
        public Int32 Checklanguage;
        private string username, athlete;
        private double results, Stance, timeForLap;

        public Speed()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
            connect = new MySqlConnection(connectionStr);
        }

        public void setLanguage(Int32 Checklanguage)
        {
            this.Checklanguage = Checklanguage;
        }
        public void setUser(string username)
        {
            this.username = username; ;
        }
        
        private void btnCalculatePace_Click(object sender, EventArgs e)
        {
             Stance = Convert.ToDouble(txtDistance.Text);
             timeForLap = TimeSpan.Parse(txtTime.Text).TotalHours;
           results = calcSpeed(Stance, timeForLap);
            txtResults.Text = Convert.ToString(results);
            WQuery = "CALL `fitness`.`Insertspeed`(\"" + results + "\",'" + Stance + "','" + timeForLap + "',\"" + athlete + "\");";
            Database.DataAccess MyData = new Database.DataAccess();
            MyData.databaseWrite(WQuery);

        }

        public double calcSpeed(double distance, double timeForLap)
        {
            double displacement = distance / 1000;
            double pace = 0;
            double time = timeForLap;
            pace = (displacement / time);

        return pace;

        }

        public void setAthlete(string athlete)
        {
            this.athlete = athlete;
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
            calc.setUser(username);
            calc.setAthlete(athlete);
            calc.Show();
            this.Hide();
        }

        private void Speed_Load(object sender, EventArgs e)
        {
            Language.LanguageSpeed speed = new Language.LanguageSpeed();

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
