using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class UpdateAthleteInfo : Form
    {
        string connectionString = @"Server=localhost;Database=operational_database;Uid=root;Pwd=root;";
        int Additional_id = 0;
        int Student_id = 0;
        public UpdateAthleteInfo()
        {
            InitializeComponent();
        }

        private void femaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Coach().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you wa'nt to cancel?");
            Application.Exit();
        }

        private void UpdateAthleteInfo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlCommand MySqlCmd = new MySqlCommand("forUpdate", mysqlCon);
                MySqlCmd.CommandType = CommandType.StoredProcedure;
                MySqlCmd.Parameters.AddWithValue("_student_id", Student_id);
                MySqlCmd.Parameters.AddWithValue("_stud_tittle", cmbTitle.Text.Trim());
                MySqlCmd.Parameters.AddWithValue("_first_name", txtFirst.Text.Trim());
                MySqlCmd.Parameters.AddWithValue("_last_name", txtLast.Text.Trim());
                MySqlCmd.Parameters.AddWithValue("_student_num", txtStudentNum.Text.Trim());
                MySqlCmd.Parameters.AddWithValue("_stu_gender", cmbGender.Text.Trim());
                MySqlCmd.Parameters.AddWithValue("_phys_address", txtAddress.Text.Trim());
                MySqlCmd.Parameters.AddWithValue("_stud_age", txtAge.Text.Trim());
                MySqlCmd.Parameters.AddWithValue("_stud_cell", txtCell.Text.Trim());
                //MySqlCmd.Parameters.AddWithValue("_stud_pass", txtPass.Text.Trim());
                // MySqlCmd.Parameters.AddWithValue("_stud_pass_confirm", txtConfPass.Text.Trim());
                MySqlCmd.Parameters.AddWithValue("_stud_email", txtEmail.Text.Trim());
                MySqlCmd.Parameters.AddWithValue("_sport", cmbSport.Text.Trim());
                MySqlCmd.Parameters.AddWithValue("_date_of_birth", txtBirthDate.Text.Trim());
                MySqlCmd.Parameters.AddWithValue("_student_res", cmbRes.Text.Trim());
                MySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully");
                GridFill();


            }
        }
        void GridFill()
        {


            using (MySqlConnection mysqlCo = new MySqlConnection(connectionString))
            {

                mysqlCo.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("studentViewAll", mysqlCo);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtble = new DataTable();
                sqlDa.Fill(dtble);
                dgShow.DataSource = dtble;
                dgShow.Columns[0].Visible = true;
                dgShow.Columns[12].Visible = false;
                dgShow.Columns[13].Visible = false;






            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {

                    mysqlCon.Open();
                    MySqlCommand MySqlCmd = new MySqlCommand("allEditAdd", mysqlCon);
                    MySqlCmd.CommandType = CommandType.StoredProcedure;
                    MySqlCmd.Parameters.AddWithValue("_additional_info_id", Additional_id);
                    MySqlCmd.Parameters.AddWithValue("_vo2max", txtVO2Max.Text.Trim());
                    MySqlCmd.Parameters.AddWithValue("_position", cmbPosition.Text.Trim());
                    MySqlCmd.Parameters.AddWithValue("_team_name", cmbTeam_Name.Text.Trim());
                    MySqlCmd.Parameters.AddWithValue("_team_type", cmbTeamType.Text.Trim());
                    MySqlCmd.Parameters.AddWithValue("_statusi", cmbStatus.Text.Trim());
                    MySqlCmd.Parameters.AddWithValue("_student_id", txtID.Text.Trim());

                    MySqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Data added successfully.");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgShow_DoubleClick(object sender, EventArgs e)
        {
            if (dgShow.CurrentRow.Index != -1)
            {
                cmbTitle.Text = dgShow.CurrentRow.Cells[1].Value.ToString();
                txtFirst.Text = dgShow.CurrentRow.Cells[2].Value.ToString();
                txtLast.Text = dgShow.CurrentRow.Cells[3].Value.ToString();
                txtStudentNum.Text = dgShow.CurrentRow.Cells[4].Value.ToString();
                cmbGender.Text = dgShow.CurrentRow.Cells[5].Value.ToString();
                txtAddress.Text = dgShow.CurrentRow.Cells[6].Value.ToString();
                txtAge.Text = dgShow.CurrentRow.Cells[7].Value.ToString();
                txtCell.Text = dgShow.CurrentRow.Cells[9].Value.ToString();
                txtEmail.Text = dgShow.CurrentRow.Cells[8].Value.ToString();
                cmbSport.Text = dgShow.CurrentRow.Cells[12].Value.ToString();
                txtBirthDate.Text = dgShow.CurrentRow.Cells[13].Value.ToString();
                cmbRes.Text = dgShow.CurrentRow.Cells[14].Value.ToString();
                Student_id = Convert.ToInt32(dgShow.CurrentRow.Cells[0].Value.ToString());
                button2.Text = "Update";


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCo = new MySqlConnection(connectionString))
            {
                //search
                mysqlCo.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("studentSearchByValue", mysqlCo);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dtble = new DataTable();
                sqlDa.Fill(dtble);
                dgShow.DataSource = dtble;
                dgShow.Columns[0].Visible = true;
                dgShow.Columns[12].Visible = false;
                dgShow.Columns[13].Visible = false;






            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                string constr = "Server=localhost;Database=operational_database;Uid=root;Pwd=root;";
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("table_joins"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            dgShow.DataSource = dt;
                            dgShow.Columns[1].Visible = false;
                        }
                    }
                }
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            new Athlete().Show();
        }
    }
}
