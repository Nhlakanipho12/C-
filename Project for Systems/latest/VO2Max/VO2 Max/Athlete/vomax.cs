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
    public partial class vomax : Form
    {

        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataReader reader;
        String connectionStr = "server=localhost;user id=root;database=fitness";
        public Int32 Checklanguage;
        private string WQuery, RQuery, sqlId, username, athlete;
        private double sqlHeight, sqlWeight, results;
        private int sqlage, count, gender;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtResults_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerT_ValueChanged(object sender, EventArgs e)
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

        public vomax()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            connect = new MySqlConnection(connectionStr);
            count = 0;
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            if (comboGender.SelectedItem.ToString() == "Male")
            {
                gender = 1;
            }
            else { gender = 0; }
            double VO2Max = 132.853 - (0.0769 * sqlWeight) -(0.3877 * sqlage) +(6.315 * gender) -(0.1565 * 150);

            txtResults.Text = Convert.ToString(VO2Max);
            WQuery = "CALL `fitness`.`InsertVOmax`('" + VO2Max + "', '" + athlete + "');";
            Database.DataAccess MyData = new Database.DataAccess();
            MyData.databaseWrite(WQuery);
        }

        private void vomax_Load(object sender, EventArgs e)
        {

            Language.LanguageBMI myLingo = new Language.LanguageBMI();

            //myLingo.setLingo(Checklanguage);
            databaseReader();
            txtHeight.Text = Convert.ToString(sqlHeight);
            txtWeight.Text = Convert.ToString(sqlWeight);
            txtAge.Text = Convert.ToString(sqlage);

        }

        public void databaseReader()
        {
            try
            {
                connect.Open();
                string[] AraySql = { "CALL `fitness`.`selectBmi`(\"" + athlete + "\");", "CALL `fitness`.`GetAge`('" + athlete + "');" };
                while (count < AraySql.Length)
                {
                    
                    RQuery = AraySql[count];
                    command = new MySqlCommand(RQuery, connect);

                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        switch (count)
                        {
                            case 0:
                                
                                sqlWeight = reader.GetDouble("weight");
                                sqlHeight = reader.GetDouble("height");
                                sqlId = reader.GetString("idathlete");
                                break;
                            case 1:
                                sqlage = reader.GetInt32("age");
                                break;
                        }


                    }
                    count++;
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An Error Occured {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               
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
    }
}
