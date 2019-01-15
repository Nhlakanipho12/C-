using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO2_Max.Language
{
    class LanguageSpeed
    {
        
            public string[] Arrayname = new string[100];

            public LanguageSpeed()
            {

            }

            string[] Afrikaans = { "Bereken Jou Pas", "Tyd", "Afstand", "Bereken", "Herstel", "Terug" };
            string[] English = { "Calculate your Pace", "Time", "Distance", "Calculate", "Reset", "Back" };
            string[] Zulu = { "Ukubala ijubane lakho","Isikhati","Ibanga","Calculate","Sekha kabusha","Emuva" };
            public string getCalcPace()
            {
                return Arrayname[0];
            }

            public string gettime()
            {
                return Arrayname[1];
            }

            public string getDistance()
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

