using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO2_Max.Classes
{
    class LanguageCoachWelcome
    {

        public string[] Arrayname = new string[100];

        public LanguageCoachWelcome()
        {

        }

        string[] Afrikaans = { "Soort by", "Hartklop", "Liggaam Massa Indeks", "Spoed", "Uitgaan","Springjunk Skedule"};
        string[] English = { "Sort By", "Heart rate","Body Mass Index", "Speed", "Logout", "Gym Schedule" };
        string[] Zulu = { "", "Isikhati", "Ibanga", "Calculate", "Sekha kabusha", "Emuva", "" };

        public string getSortBy()
        {
            return Arrayname[0];
        }

        public string getHeartRate()
        {
            return Arrayname[1];
        }

        public string getBMI()
        {
            return Arrayname[2];
        }

        public string getSpoed()
        {
            return Arrayname[3];
        }

        public string getLogout()
        {
            return Arrayname[4];
        }

        public string getSchedule()
        {
            return Arrayname[5];
        }


        public void setLingo(Int32 check)
        {
            int i = check;

            switch (i)
            {
                case 1:
                    Afrikaans.CopyTo(Arrayname, 0);
                    break;

                case 2:
                    English.CopyTo(Arrayname, 0);
                    break;

                case 3:
                    Zulu.CopyTo(Arrayname, 0);
                    break;

            }
        }
    }
}

