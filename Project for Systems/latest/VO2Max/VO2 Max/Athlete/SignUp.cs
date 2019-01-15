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
    public partial class SignUp : Form
    {
        private string password,Repassword, name, surname, idnum, contact, email,blood,address,username,usertype;
        private double height, weight;
        private int age;
        public Int32 Checklanguage;

        String connectionStr = "server=localhost;user id=root;database=fitness";

        MySqlConnection connect;
        MySqlCommand command;
        private string sqlQuery;


        public SignUp()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            connect = new MySqlConnection(connectionStr);
            usertype = "athlete";
            labelMatchPass.Visible = false;
        }

        public void database()
        {
            try
            {
                connect.Open();

            sqlQuery = "CALL fitness.RegisterAthlete(\""+idnum+"\", '"+username+"',\""+name+"\", '"+surname+"','"+contact+"','"+email+"','"+ address+"','"+password+"', '"+ blood+"','"+height+"', '"+weight+"', '"+age+"','"+usertype+"';" ;
            //"INSERT INTO user ( iduser ,name, surname, password , contact,email,address,username)VALUES('" +idnum+"','"+name+"','"+surname+"','"+password+"','"+contact+"','"+email+"','"+address+"','"+username+"');";
            command = new MySqlCommand(sqlQuery, connect);
            command.ExecuteNonQuery();
            command.CommandType = CommandType.StoredProcedure;

            connect.Close();

        }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("An Error Occured {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
}

        private void SetUsername()
        {
            username = "UA" + name.Substring(0,1)+ surname.Substring(0,1) + idnum.Substring(6, 10); 
        }
        private void setAge()
        {
            int fulyear;
            int yr = Convert.ToInt32(idnum.Substring(0,2));
            if (yr <= 40 && yr >= 0)
            {
                fulyear = 2000 + yr;
            }
            else
            {
                fulyear = 1900 + yr;
            }

            age = 2016 - fulyear;
        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            CheckInfo();
            

            if (Checking() == true && CheckInfo() == true)
            { 
                SetUsername();
                setAge();
                database();

                Welcome myWelcome = new Welcome();
                myWelcome.Show();
                this.Hide();
            }
            else
            {
                labelMatchPass.Show();
            }
        }

        private bool CheckInfo()
        {
            bool check = false;
            Classes.SignUPExceptionhandling Exc = new Classes.SignUPExceptionhandling();
            ExtraForms.MessageBoxException Msg = new ExtraForms.MessageBoxException();

            try
            {

                if (Exc.checkNOTNull(textBoxName.Text) == true)
                {
                    name = textBoxName.Text;
                    check = true;
                }
                else
                {
                    lblNameEX.Show();
                    check = false;
                }

                if (Exc.checkNOTNull(textBoxSurname.Text) == true)
                {
                    surname = textBoxSurname.Text;
                    check = true;
                }
                else
                {
                    lblSunameEX.Show();
                    check = false;
                }

                if (Exc.checkNOTNull(textBoxOfficeAddress.Text) == true)
                {
                    address = textBoxOfficeAddress.Text;
                    check = true;
                }
                else
                {
                    lblAllInfo.Show();
                    check = false;
                }

                if (Exc.checkNOTNull(comboBoxBlood.SelectedItem.ToString()) == true)
                {
                    blood = comboBoxBlood.SelectedItem.ToString();
                    check = true;
                }
                else
                {
                    lblAllInfo.Show();
                    check = false;
                }

                if (Exc.checkNOTNull(txtPassword.Text) == true)
                {
                    password = txtPassword.Text;
                    check = true;
                }
                else
                {
                    labelMatchPass.Text = "Password cannot be empty";
                    labelMatchPass.Show();
                    check = false;
                }

                if (Exc.checkID(textBoxId.Text) == true)
                {
                    idnum = textBoxId.Text;
                    check = true;
                }
                else
                {
                    lblIdnumEX.Show();
                    check = false;
                }

                if (Exc.checkContact(textBoxContact.Text) == true)
                {
                    contact = textBoxContact.Text;
                    check = true;
                }
                else
                {
                    lblcontactEX.Show();
                    check = false;
                }

                
            email = textBoxEmail.Text;
            height = Convert.ToDouble(textBoxHeight.Text);
            weight = Convert.ToDouble(textBoxWeight.Text);        
            Repassword = txtReEnterPassword.Text;

               
            }
            catch (Exception ex)
            {
                Msg.display(ex.Message);
            }

            return check;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            labelMatchPass.Visible = false;
            Language.LanguageSignUp myLingo = new Language.LanguageSignUp();

            myLingo.setLingo(Checklanguage);

            labelName.Text = myLingo.getName();
            labelSurname.Text = myLingo.getSurname();
            labelIDnum.Text = myLingo.getIDNumber();
            labelContact.Text = myLingo.getContactNumber();
            labelEmail.Text = myLingo.getCEmailAddress();
            labelHeight.Text = myLingo.getHeight();
            labelWeight.Text = myLingo.getWWeight();
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
               
            }
            else
            {
                labelMatchPass.ForeColor = Color.Red;
              
                labelMatchPass.Text = "Password doesnot match";
                labelMatchPass.Visible = true;

            }
            labelMatchPass.Visible = true;
        }

        private bool Checking()
        {

            if (password == Repassword)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
       
        private void linkLabelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Classes.About Info = new Classes.About();
            Info.Information();
        }
    }
}
