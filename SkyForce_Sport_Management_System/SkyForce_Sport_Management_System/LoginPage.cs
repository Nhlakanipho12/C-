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
    public partial class Login_Page : Form
    {
        MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=operational_database;Uid=root;Pwd=root;");
        int Idcoach;
        int idStudent;


        public Login_Page()
        {
            InitializeComponent();

        }
        WelcomePageNew fo = new WelcomePageNew();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void SignUPlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            new RegistrationPage().Show();
        }

        private void btbLogin_Click(object sender, EventArgs e)
        {

            //coach

            if (SelectUSercomboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please user type.");

            }

            if (SelectUSercomboBox1.Text == "Coach" && SelectUSercomboBox1.SelectedItem != null && textBox1.Text != null && textBox2.Text != null)
            {
                Idcoach = 0;

                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from coach where coach_email='" + textBox1.Text + "' and pass1='" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                Idcoach = Convert.ToInt32(dt.Rows.Count.ToString());

                if (Idcoach == 0)
                {
                    MessageBox.Show("Invalid username or password.");
                }
                else
                {
                    this.Visible = false;
                    WelcomePageNew f1 = new WelcomePageNew();
                    f1.Show();
                    MessageBox.Show("Login as Coach");
                }
                con.Close();

            }


            //student

                if (SelectUSercomboBox1.Text == "Student" && SelectUSercomboBox1.SelectedItem != null && textBox1.Text != null && textBox2.Text != null)
                {
                    idStudent = 0;

                    con.Open();
                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select * from student where stud_email='" + textBox1.Text + "' and stud_pass='" + textBox2.Text + "'";
                    cmd1.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                    da1.Fill(dt1);
                    idStudent = Convert.ToInt32(dt1.Rows.Count.ToString());

                    if (idStudent == 0)
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                    else
                    {
                        this.Visible = false;
                        WelcomePageNew f1 = new WelcomePageNew();
                        f1.Show();
                        MessageBox.Show("Login as Student");
                    }
                        con.Close();
                }
                

                //(this.Owner as WelcomePageNew).button4.Enabled = false;
                //this.Visible = false;
                // new WelcomePageNew().Show();
                //WelcomePageNew.mdi.button4.Enabled = false;



            





        }
        private void btbCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you wa'nt to cancel?");
            Application.Exit();
        }
    }
}



