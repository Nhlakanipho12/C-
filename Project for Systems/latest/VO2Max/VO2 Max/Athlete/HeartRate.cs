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
    public partial class HeartRate : Form
    {

        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataReader reader;
        String connectionStr = "server=localhost;user id=root;database=fitness";

        public int sqlage;
        public Int32 Checklanguage;
        public string username,sqlQuery, WQuery, athlete;
        private double calculation;
       

        public HeartRate()
        {
            InitializeComponent();
           
            connect = new MySqlConnection(connectionStr);
        }

        public void databaseReader()
        {
            try
            {
                connect.Open();

                sqlQuery = "CALL `fitness`.`GetAge`('"+athlete+"');";
                command = new MySqlCommand(sqlQuery, connect);

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sqlage = reader.GetInt32("age");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An Error Occured {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reader.Close();
                connect.Close();
            }
        }

        public void setLanguage(Int32 Checklanguage)
        {
            this.Checklanguage = Checklanguage;
        }
        public void setUser(string username)
        {
            this.username = username; ;
        }

        public void setAthlete(string athlete)
        {
            this.athlete = athlete;
        }

        private void HeartRate_Load(object sender, EventArgs e)
        {
            Language.LanguageHeartRate myLingo = new Language.LanguageHeartRate();

            myLingo.setLingo(Checklanguage);

            labelTitle.Text = myLingo.getCalcHeartRate();
            lblAge.Text = myLingo.getAge();
            lblExerciseLevel.Text = myLingo.getExcercise();
            buttonCalculate.Text = myLingo.getCalculate();
            btnReset.Text = myLingo.getReset();
            buttonBack.Text = myLingo.getBack();
            databaseReader();
            txtAge.Text = Convert.ToString(sqlage);




        }

        private void ComboExercise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            sqlage = Convert.ToInt32(txtAge.Text);
            double level = (Convert.ToInt32(ComboExercise.SelectedItem.ToString()));
            calculation = calcHeartRateNormal(sqlage, level);
            string rslt = Convert.ToString(calculation);
            txtResults.AppendText(rslt);
            WQuery = "CALL `fitness`.`InsertHrate`('" + calculation + "', '" + athlete + "');";
            Database.DataAccess MyData = new Database.DataAccess();
            MyData.databaseWrite(WQuery);

        }

        public double calcHeartRateNormal(int age, double level)
        {
            double convertTopercentage;
            int constant = 220;

            convertTopercentage = level / 100.00;



            return convertTopercentage * (constant - age);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResults.Clear();
            txtAge.Clear();
            ComboExercise.ResetText();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Calculation calc = new Calculation();
            calc.setLanguage(Checklanguage);
            calc.setAthlete(athlete);
            calc.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Calculation calc = new Calculation();
            calc.setLanguage(Checklanguage);
            calc.setUser(username);
            calc.Show();
            this.Hide();
        }

       
    }
}
