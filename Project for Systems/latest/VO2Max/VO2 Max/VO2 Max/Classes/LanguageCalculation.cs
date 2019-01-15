using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO2_Max.Classes
{
    class LanguageCalculation
    {
        public string[] Arrayname = new string[100];

        public LanguageCalculation()
        {

        }

        string[] CalcAfrikaans = { "LMI", "Spoed", "dieet", "Hart Valueer", "Uitgaam"};
        string[] CalcEnglish = { "BMI", "Speed", "Diet", "Heart Rate", "Logout"};
        string[] CalcZulu = { "BMI","Isivinini", "Ukudla", "Isilinganiso sentliziyo","Phuma"};

        public string getBMI()
        {
            return Arrayname[0];
        }

        public string getSpeed()
        {
            return Arrayname[1];
        }

        public string getBodyFat()
        {
            return Arrayname[2];
        }

        public string getHeartRate()
        {
            return Arrayname[3];
        }

        public string getUitgaan()
        {
            return Arrayname[4];
        }


        public void setLingo(Int32 check)
        {
            int i = check;

            switch (i)
            {
                case 1:
                    CalcAfrikaans.CopyTo(Arrayname, 0);
                    break;

                case 2:
                    CalcEnglish.CopyTo(Arrayname, 0);
                    break;

                case 3:
                    CalcZulu.CopyTo(Arrayname, 0);
                    break;

            }
        }
    }
}
