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
    public partial class TeamRegister : Form
    {
        public TeamRegister()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            CoachWelcome welcome = new CoachWelcome();
            welcome.Show();
            this.Hide();
        }
    }
}
