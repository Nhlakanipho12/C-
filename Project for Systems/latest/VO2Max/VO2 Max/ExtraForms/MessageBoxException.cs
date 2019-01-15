using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VO2_Max.ExtraForms
{
    class MessageBoxException

    {
        public void display(string ex)
        {

            MessageBox.Show(string.Format("An error occurred {0}", ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
