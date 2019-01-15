using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO2_Max.Language
{
    class LanguageHeartRate
    {
        public string[] Arrayname = new string[100];

        public LanguageHeartRate()
        {

        }

        string[] HrateAfrikaans = { "Bereken Hart valueer", "Ouderdom", "Oefening vlak", "Bereken", "Herstel", "Terug" };
        string[] HrateEnglish = { "Calculate Heart Rate", "Age", "Excercise Level", "Calculate", "Reset", "Back" };
        string[] HrateZulu = { "Calculate Amafutha wemzimba","zinyaga","Exercise Izinga","Calculate" ,"Sekha kabusha","Emuva"};

        public string getCalcHeartRate()
        {
            return Arrayname[0];
        }

        public string getAge()
        {
            return Arrayname[1];
        }

        public string getExcercise()
        {
            return Arrayname[2];
        }

        public string getCalculate()
        {
            return Arrayname[3];
        }

        public string getReset()
        {
            return Arrayname[4];
        }

        public string getBack()
        {
            return Arrayname[5];
        }

        public void setLingo(Int32 check)
        {
            int i = check;

            switch (i)
            {
                case 1:
                    HrateAfrikaans.CopyTo(Arrayname, 0);
                    break;

                case 2:
                    HrateEnglish.CopyTo(Arrayname, 0);
                    break;

                case 3:
                    HrateZulu.CopyTo(Arrayname, 0);
                    break;

            }
        }
    }
}
