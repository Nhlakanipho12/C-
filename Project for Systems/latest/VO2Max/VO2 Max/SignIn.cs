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

namespace VO2_Max
{
    public partial class SignIn : Form
    {
        String connectionStr = "server=localhost;user id=root;database=fitness";

        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        private string sqlQuery;

        public string Username, msg, btnYes, btnNo;
        public string Password,sqlPassword,sqlName;
        public Int32 Checklanguage;
        
        public SignIn()
        {
            InitializeComponent();
            Checklanguage = 1;
            this.StartPosition = FormStartPosition.CenterScreen;           
           connect = new MySqlConnection(connectionStr);

        }

        public void database(string username, string password)
        {

            try {
                connect.Open();
                string a = "CALL `fitness`.`SelectlogIn`(\"" + username+"\");";
                //sqlQuery = "SELECT name , password FROM user WHERE username = '" + username + "';";
                command = new MySqlCommand(a, connect);

                //command.CommandText = "loggingIn";


                //command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.Add(new MySqlParameter("@Uname",MySqlDbType.VarChar).Value = username);
                //command.ExecuteNonQuery();        used for executing insert/update/delete query
                //command.CommandType = CommandType.StoredProcedure;

                //dapter = new MySqlDataAdapter(command);

                //command.ExecuteNonQuery();

                //DataTable table = new DataTable();

                //adapter.Fill(table);

                //MessageBox.Show(table.Rows[0][0].ToString()+" "+ table.Rows[0][1].ToString());

                

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sqlPassword = reader.GetString("password");
                    sqlName = reader.GetString("name");
                }
                //myTable.Load(dataReader);
               

            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
                connect.Close();
            }
            
        }

        public string getusername()
        {
            return Username;
        }

        private bool Checkpassword()
        {
            if (sqlPassword == Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Username = txtUsername.Text;
            Password = txtPassword.Text;

            database(Username, Password);

            if (Checkpassword() == true)
            {
                usertype();
            }
            else
            {
                MessageBox.Show(string.Format("An error occurred {0}", "Password doesn't match. Please contact the administrator"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        public void setLanguage(Int32 Checklanguage)
        {
            this.Checklanguage = Checklanguage;
        }

        public int mylingocheck()
        {
            return Checklanguage;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Classes.About Info = new Classes.About();
            Info.Information();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                    }

        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch (mylingocheck())
            {
                case 1:
                    ExtraForms.RegisterView myMsg = new ExtraForms.RegisterView("Out", "Ja", "Nee","Kanselleer",mylingocheck());
                    myMsg.Show();
                    this.Hide();
                    break;
                case 2:
                    ExtraForms.RegisterView myMs = new ExtraForms.RegisterView("Do you want to register as an Athlete?", "Yes", "No","Cancel", mylingocheck());
                    myMs.Show();
                    this.Hide();
                    break;
                case 3:
                    ExtraForms.RegisterView myMg = new ExtraForms.RegisterView("Out", "Yebo", "Qha","Translate", mylingocheck());
                    myMg.Show();
                    this.Hide();
                    break;
            }


        }
        private void MessageDisplay()
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            switch (Checklanguage)
            {
                case 1:
                     msg = "Is seker jy wil aansoek uitgaan ?";
                     btnYes = "Ja";
                     btnNo = "Nee";
                    break;

                case 2:
                    msg = "Are Sure You Want To Exit application?";
                    btnYes = "Yes";
                    btnNo = "No";
                    break;

                case 3:
                    msg = "Ingabe uqinisekile ukuthi ufuna ukuphuma isicelo ?";
                    btnYes = "Yebo";
                    btnNo = "Qha";
                    break;

            }
            
                ExtraForms.MessageView MYmsg = new ExtraForms.MessageView(msg, btnYes, btnNo);
                MYmsg.setMgsClass("SignIn");
            MYmsg.setCheckLanguage(Checklanguage);
                MYmsg.Show();   
        }

        private void afrikaansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Language.LanguageSignIn myLingo = new Language.LanguageSignIn("SignIn", "Afrikaans");

            Checklanguage = 1;
            myLingo.setLingo(Checklanguage);

            lblUsername.Text = myLingo.getUsername();
            lblPassword.Text = myLingo.getPassword();
            btnLogin.Text = myLingo.getLogin();
            btnExit.Text = myLingo.getExit();
            linkLabelSignUp.Text = myLingo.getSignUp();
            linkLabelAbout.Text = myLingo.getClickHere();
            grpSocialNetworks.Text = myLingo.getFollowUs();

        }

        private void defaultLingo()
        {
            Language.LanguageSignIn myLingo = new Language.LanguageSignIn("SignIn", "Afrikaans");

            myLingo.setLingo(Checklanguage);

            lblUsername.Text = myLingo.getUsername();
            lblPassword.Text = myLingo.getPassword();
            btnLogin.Text = myLingo.getLogin();
            btnExit.Text = myLingo.getExit();
            linkLabelSignUp.Text = myLingo.getSignUp();
            linkLabelAbout.Text = myLingo.getClickHere();
            grpSocialNetworks.Text = myLingo.getFollowUs();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            this.setLanguage(Checklanguage);
            this.defaultLingo();

            
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void picFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Vo2MaxTraining/?ref=br_rs");
        }

        private void picTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.twitter.com");
        }

        private void picInsta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/accounts/login");
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Language.LanguageEnglish myLingo = new Language.LanguageEnglish("SignIn", "English");
            Language.LanguageSignIn myLingo = new Language.LanguageSignIn("SignIn", "Afrikaans");

            Checklanguage = 2;

            myLingo.setLingo(Checklanguage);

            lblUsername.Text = myLingo.getUsername();
            lblPassword.Text = myLingo.getPassword();
            btnLogin.Text = myLingo.getLogin();
            btnExit.Text = myLingo.getExit();
            linkLabelSignUp.Text = myLingo.getSignUp();
            linkLabelAbout.Text = myLingo.getClickHere();
            grpSocialNetworks.Text = myLingo.getFollowUs();
        }

        private void isiZuluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Language.LanguageSignIn myLingo = new Language.LanguageSignIn("SignIn", "Afrikaans");

            Checklanguage = 3;

            myLingo.setLingo(Checklanguage);

            lblUsername.Text = myLingo.getUsername();
            lblPassword.Text = myLingo.getPassword();
            btnLogin.Text = myLingo.getLogin();
            btnExit.Text = myLingo.getExit();
            linkLabelSignUp.Text = myLingo.getSignUp();
            linkLabelAbout.Text = myLingo.getClickHere();
            grpSocialNetworks.Text = myLingo.getFollowUs();
        }

        

        private void usertype()
        {

        if (Username.Substring(0, 2) == "UA" || Username.Substring(0, 2) == "ua")
        {
            Athlete.Calculation calc = new Athlete.Calculation();
            calc.setLanguage(Checklanguage);
                calc.setUser(sqlName);
                calc.setAthlete(Username);
            calc.Show();
            this.Hide();
        }
        else
        {
            if (Username.Substring(0, 2) == "UC" || Username.Substring(0, 2) == "uc")
            {
                Coach.CoachWelcome welcome = new Coach.CoachWelcome();
                welcome.setLanguage(Checklanguage);
                welcome.Show();
                this.Hide();
            }
        }

      }
    }
    }

