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
    public partial class MainSignUp : Form
    {
        public bool match;
        public string password, name, surname, id, contact, email;
        public Int32 Checklanguage;

      
        

        public MainSignUp()
        {
            InitializeComponent();
            labelMatchPass.Visible = false;
            match = false;
        }

        private void MainSignUp_Load(object sender, EventArgs e)
        {
            labelMatchPass.Visible = false;
            Classes.LanguageSignUp myLingo = new Classes.LanguageSignUp();

            myLingo.setLingo(Checklanguage);

            labelName.Text = myLingo.getName();
            labelSurname.Text = myLingo.getSurname();
            labelIDnum.Text = myLingo.getIDNumber();
            labelContact.Text = myLingo.getContactNumber();
            labelEmail.Text = myLingo.getCEmailAddress();
            radioButtonCoach.Text = myLingo.getHeight();
            radioButtonNutritionist.Text = myLingo.getWWeight();
            labelOffice.Text = myLingo.getOfficeAdress();
            groupBoxCreate.Text = myLingo.getCreatePass();
            groupBoxSignup.Text = myLingo.getSignUp();
            labelNewPassword.Text = myLingo.getNewPass();
            labelRepassword.Text = myLingo.getConfirmPass();
            btnSignUp.Text = myLingo.getSignUp();
            labelstep2.Text = myLingo.getStep2();
            labelstep1.Text = myLingo.getStep1();
            buttonBack.Text = myLingo.getBack();

        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            SignIn mySignIn = new SignIn();
            mySignIn.setLanguage(Checklanguage);
            mySignIn.Show();
            this.Hide();
        }

        private void linkLabelAbout_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        public void setLanguage(Int32 Checklanguage)
        {
            this.Checklanguage = Checklanguage;
        }

        private void txtReEnterPassword_Leave(object sender, EventArgs e)
        {
            password = txtPassword.Text;
            string ReEntPassword = txtReEnterPassword.Text;
            if (password == ReEntPassword)
            {

                labelMatchPass.ForeColor = Color.Green;
                //labelMatchPass.Text = myLingo.getMatch();
                labelMatchPass.Text = "Password Match";
                labelMatchPass.Visible = true;
                match = true;
            }
            else
            {
                labelMatchPass.ForeColor = Color.Red;

                labelMatchPass.Text = "Password doesnot match";
                labelMatchPass.Visible = true;

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
                Coach.TeamRegister team = new Coach.TeamRegister();
                team.Show();
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
