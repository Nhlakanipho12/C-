using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VO2_Max.Classes
{
    class About
    {
        public void Information()
        {
            MessageBox.Show("The objective of the Multi-Stage Fitness Test (MSFT), developed by Leger &amp; Lambert (1982), is to monitor the " +

"development of the athlete's  maximum oxygen uptake (VO 2 max). Now with that in mind, our program will make use " +

"of the results obtained from the test, and process them to calculate each individual’s VO 2 max accurately, and offer " +

"advice on how they can improve for the next assessment.Our MSFTP will help NWU sports players to increase their " +

"maximum oxygen intake(VO 2 max).By doing so, they’ll be able to perform and think more effectively, so having " +

"players with high oxygen intakes would be an advantage for the team.", "About product version: " );

        }
    }
}
