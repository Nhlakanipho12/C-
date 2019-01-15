using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VO2_Max.Nutritionist
{
    public partial class ViewDiet : Form
    {

        public Int32 Checklanguage;
        private string username;

        public ViewDiet()
        {
            InitializeComponent();
        }

        public void setLanguage(Int32 Checklanguage)
        {
            this.Checklanguage = Checklanguage;
        }

        public void setUser(string username)
        {
            this.username = username; ;
        }

        private void ViewDiet_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Athlete.Calculation calc = new Athlete.Calculation();
            calc.setLanguage(Checklanguage);
            calc.setUser(username);
            calc.Show();
            this.Hide();
        }
    }
}
