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

namespace SkyForce_Sport_Management_System
{
    public partial class RegistrationPage : Form

        
    {
        string connectionString = @"Server=localhost;Database=operational_database;Uid=root;Pwd=root;";
        int Student_id =0;
        int idCoach = 0;
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you wa'nt to cancel?");
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Login_Page().Show();
        }
        

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "" || txtConfPass.Text == "" || txtAddress.Text == "" || txtAge.Text == "" || txtCell.Text == "" || txtEmail.Text == "" || txtFirst.Text == "" || txtLast.Text == "" || txtStudent_num.Text == "" || cmbBirthDate.Text == "" || cmbGender.Text == "" || cmbHealth.Text == "" || cmbTitle.Text == "" || cmbRes.Text == "")
            {
                MessageBox.Show("Please fill in all mandatory fields");
            }

            if (txtPass.Text != txtConfPass.Text)
            {
                MessageBox.Show("Passwords do not match");

            }
            //student


            if (comboBoxUsertype.SelectedItem == null)
            {
                MessageBox.Show("Please user type.");
            }
            else
            {
                if (comboBoxUsertype.Text == "Student")
                {
                    using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                    {

                        mysqlCon.Open();
                        MySqlCommand MySqlCmd = new MySqlCommand("studentAdrOrEdit", mysqlCon);
                        MySqlCmd.CommandType = CommandType.StoredProcedure;
                        MySqlCmd.Parameters.AddWithValue("_student_id", Student_id);
                        MySqlCmd.Parameters.AddWithValue("_stud_tittle", cmbTitle.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_first_name", txtFirst.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_last_name", txtLast.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_student_num", txtStudent_num.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_stu_gender", cmbGender.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_phys_address", txtAddress.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_stud_age", txtAge.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_stud_cell", txtCell.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_stud_pass", txtPass.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_stud_pass_confirm", txtConfPass.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_stud_email", txtEmail.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_sport", cmbSport.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_date_of_birth", cmbBirthDate.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_student_res", cmbRes.Text.Trim());
                        MySqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Student registration successful");
                        Clear();
                    }
                }
                
            }

            {
               
            }




            //coach
            if (comboBoxUsertype.SelectedItem == null)
            {
                MessageBox.Show("Please user type.");
            }
            else
            {


                if (comboBoxUsertype.Text == "Coach")
                {
                    using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                    {

                        mysqlCon.Open();
                        MySqlCommand MySqlCmd = new MySqlCommand("coachAll", mysqlCon);
                        MySqlCmd.CommandType = CommandType.StoredProcedure;
                        MySqlCmd.Parameters.AddWithValue("_idcoach", idCoach);
                        MySqlCmd.Parameters.AddWithValue("_coach_first_name", txtFirst.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_coach_tittle", cmbTitle.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_coach_last_name", txtLast.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_coach_gender", cmbGender.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_coach_address", txtAddress.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_coachage", txtAge.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_coach_cell", txtCell.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_coach_email", txtEmail.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_coach_sport", cmbSport.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_coach_date", cmbBirthDate.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_pass1", txtPass.Text.Trim());
                        MySqlCmd.Parameters.AddWithValue("_pass2", txtConfPass.Text.Trim());
                        //MySqlCmd.Parameters.AddWithValue("_student_res", cmbRes.Text.Trim());
                        MySqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Coach registration successful");
                    
                        Clear();

                    }
                }



        }   }

                void Clear()
                {
                    cmbTitle.Text = txtFirst.Text = txtLast.Text = txtStudent_num.Text = txtAddress.Text =
                    txtAge.Text = txtPass.Text = txtConfPass.Text = txtEmail.Text = txtCell.Text = "";
                }

    }
}

        

      

        
    

