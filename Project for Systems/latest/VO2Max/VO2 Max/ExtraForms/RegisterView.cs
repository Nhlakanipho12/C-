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
    public partial class RegisterView : Form
    {
        private string message, buttonYes, buttonNo, btnCancel;
        private Int32 Checklanguage;

        public RegisterView(string message, string buttonYes, string buttonNo, string btnCancel, Int32 Checklanguage)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.message = message;
            this.buttonYes = buttonYes;
            this.buttonNo = buttonNo;
            this.btnCancel = btnCancel;
            this.Checklanguage = Checklanguage;
        }

        private void RegisterView_Load(object sender, EventArgs e)
        {
            lblMsg.Text = message;
            lblMsg.Show();
            btnYes.Text = buttonYes;
            btnYes.Show();
            btnNo.Text = buttonNo;
            btnNo.Show();
            buttonCancel.Text = btnCancel;
            buttonCancel.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            SignIn mysign = new SignIn();
            mysign.setLanguage(Checklanguage);
            mysign.Show();
            this.Hide();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            SignUp mySignUp = new SignUp();
            mySignUp.setLanguage(Checklanguage);
            mySignUp.Show();
            this.Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MainSignUp myMain = new MainSignUp();
            myMain.setLanguage(Checklanguage);
            myMain.Show();
            this.Hide();
        }
    }
}
