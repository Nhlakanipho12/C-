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
    public partial class TournamentDetails : Form
    {
        string connectionString = @"Server=localhost;Database=operational_database;Uid=root;Pwd=root;";
        int Announcements_id =0;
        
        public TournamentDetails()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you wa'nt to cancel?");
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {

                    mysqlCon.Open();
                    MySqlCommand MySqlCmd = new MySqlCommand("announcement", mysqlCon);
                    MySqlCmd.CommandType = CommandType.StoredProcedure;
                    MySqlCmd.Parameters.AddWithValue("_announcements_id", Announcements_id);
                    MySqlCmd.Parameters.AddWithValue("_announcement_date", cmbBirthDate.Text.Trim());
                    MySqlCmd.Parameters.AddWithValue("_announcements_recent", textBox1.Text.Trim());
                    

                    MySqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Announcement added successfully.");
                    GridFill();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        void GridFill()
        {


            string constr = "Server=localhost;Database=operational_database;Uid=root;Pwd=root;";
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("selectZonke"))
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void dgShow_DoubleClick(object sender, EventArgs e)
        {
           // GridFill();
        }
    }
}
