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
    public partial class BMI : Form
    {
        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataReader reader;
        String connectionStr = "server=localhost;user id=root;database=fitness";
        private string WQuery, RQuery, sqlId, username, athlete;
        private double sqlHeight, sqlWeight,results;
       

       

        public Int32 Checklanguage;

        public BMI()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            connect = new MySqlConnection(connectionStr);
           
            SignIn sign = new SignIn();
           
        }
        

        public void databaseReader()
        {
            try
            {
                connect.Open();

                RQuery = "CALL `fitness`.`selectBmi`(\"" + athlete + "\");";
                command = new MySqlCommand(RQuery, connect);

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sqlHeight = reader.GetDouble("height");
                    sqlWeight = reader.GetDouble("weight");
                    sqlId = reader.GetString("idathlete");
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

        public void setAthlete(string athlete)
        {
            this.athlete = athlete;
        }

        public void setUser(string username)
        {
            this.username = username; ;
        }

        public void setLanguage(Int32 Checklanguage)
        {
            this.Checklanguage = Checklanguage;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ComboMeasurement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtResultBMI_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonChild_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAdult_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblLine_Click(object sender, EventArgs e)
        {

        }

        private void lblCalculate_Click(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPounts_Click(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWeight_Click(object sender, EventArgs e)
        {

        }

        private void lblHeight_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtResultBMI.Clear();

            double height = Convert.ToDouble(txtHeight.Text);
            double Weight = Convert.ToDouble(txtWeight.Text);

            string measurement = ComboMeasurement.SelectedItem.ToString();

             results = BMICalculate(measurement, Weight, height);
            txtResultBMI.AppendText(Convert.ToString(results));
            WQuery = "CALL `fitness`.`InsertBMI`('" + results + "', '" + athlete + "');";
            //WQuery = "UPDATE fitness.record SET bmi = '" + results + "' WHERE username = '" + athlete + "'; ";
            Database.DataAccess MyData = new Database.DataAccess();
            MyData.databaseWrite(WQuery);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void BMI_Load(object sender, EventArgs e)
        {
            Language.LanguageBMI myLingo = new Language.LanguageBMI();

            myLingo.setLingo(Checklanguage);
            databaseReader();
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
            databaseReader();
            txtHeight.Text = Convert.ToString(sqlHeight);
            txtWeight.Text = Convert.ToString(sqlWeight);
            



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
