using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VO2_Max.ExtraForms
{
    public partial class MessageView : Form
    {
        private string message, buttonText1, buttonText2, Formmsg;
        private Int32 CheckLanguage;

        public MessageView(string message, string buttonText1, string buttonText2)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.message = message;
            this.buttonText1 = buttonText1;
            this.buttonText2 = buttonText2;
        }

       public void setMgsClass(string formmsg)
        {
            this.Formmsg = formmsg;
        }

        public void setCheckLanguage(Int32 CheckLanguage)
        {
            this.CheckLanguage = CheckLanguage;
        }

        public string getFormMsg()
        {
            return Formmsg;
        }

        private void Message_Load(object sender, EventArgs e)
        {
            lblMsg.Text = message;
            lblMsg.Show();
            btnYes.Text = buttonText1;
            btnYes.Show();
            btnNo.Text = buttonText2;
            btnNo.Show();
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (getFormMsg() == "SignIn")
            {
                Application.Exit();
            }
            else
            {
                SignIn myIn = new SignIn();
                myIn.setLanguage(CheckLanguage);
                myIn.Show();
                this.Hide();
            }
            
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (getFormMsg() == "SignIn")
            {
                this.Hide();
            }
            else
            {
                Coach.CoachWelcome welcome = new Coach.CoachWelcome();
                welcome.setLanguage(CheckLanguage);
                welcome.Show();
                this.Hide();
            }
        }
    }
    }

