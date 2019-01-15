using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VO2_Max
{
    public partial class SignUp : Form
    {
        public bool match;
        public string password;
        public string name;
        public string id;
        public string residence;

        public SignUp()
        {
            InitializeComponent();
            labelMatchPass.Visible = false;
            match = false;
        }

        private void txtReEnterPassword_Leave(object sender, EventArgs e)
        {
            string Password = txtPassword.Text;
            string ReEntPassword = txtReEnterPassword.Text;
            if (Password == ReEntPassword)
            {

                labelMatchPass.ForeColor = Color.Green;
                labelMatchPass.Text = "Password Match";
                 match = true;
                password = Password;
            }
            else
            {
                labelMatchPass.ForeColor = Color.Red;
                labelMatchPass.Text = "Password doesnot match";
                
            }
            labelMatchPass.Visible = true;
        }

        private Boolean Checking()
        {

            if (match == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (Checking() == true)
            {               
                Welcome myWelcome = new Welcome();
                myWelcome.Show();
                this.Hide();
            }
        }

        private void linkLabelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Classes.About Info = new Classes.About();
            Info.Information();
        }
    }
}
