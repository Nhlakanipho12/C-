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
    public partial class SoccerTournament : Form
    {
        public SoccerTournament()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new SportPage().Show();
        }
    }
}
