using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VO2_Max.Coach
{
    public partial class CoachWelcome : Form
    {
        public CoachWelcome()
        {
            InitializeComponent();
        }

        public Int32 Checklanguage;
        public string msg, btnYes, btnNo;

        private void CoachWelcome_Load(object sender, EventArgs e)
        {

            Classes.LanguageCoachWelcome CWelcome = new Classes.LanguageCoachWelcome();

            CWelcome.setLingo(Checklanguage);

            groupBoxSort.Text = CWelcome.getSortBy();
            radioButtonHeartRate.Text = CWelcome.getHeartRate();
            radioButtonBMI.Text = CWelcome.getBMI();
            radioButtonSpeed.Text = CWelcome.getSpoed();
            labelSchedule.Text = CWelcome.getSchedule();
            btnLogout.Text = CWelcome.getLogout();
        }

        public void setLanguage(Int32 Checklanguage)
        {
            this.Checklanguage = Checklanguage;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            switch (Checklanguage)
            {
                case 1:
                    msg = "Is seker jy wil uitgaan ?";
                    btnYes = "Ja";
                    btnNo = "Nee";
                    break;

                case 2:
                    msg = "Are Sure You Want To Logout?";
                    btnYes = "Yes";
                    btnNo = "No";
                    break;

                case 3:
                    msg = "Ingabe uqinisekile ukuthi ufuna ukuphuma?";
                    btnYes = "Yebo";
                    btnNo = "Qha";
                    break;

            }

            ExtraForms.MessageView MYmsg = new ExtraForms.MessageView(msg, btnYes, btnNo);
            MYmsg.setCheckLanguage(Checklanguage);
            MYmsg.Show();
            this.Hide();

        }
    }
}
