using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO2_Max.Classes
{
    class LanguageBMI
    {
        public string[] Arrayname = new string[100];

        public LanguageBMI()
        {

        }

        string[] Afrikaans = { "Liggaam Massa Indeks", "Bereken vir", "Volwassw LMI", "Kinders LMI", "Jou Hoogte", "Jou Gewig","Bereken","Herstel","Terug","meter","Kilogram" };
        string[] English = { "Body Mass Index", "Calculate For", "Adult BMI", "Children BMI", "Your Height", "Your Weight","Calculate","Reset","Back","metre","Kilogram" };
        string[] Zulu = { "", "Calculatela", "Omdala BMI", "Izingane", "Ukuphakama Kwakho", "isisindo sakho", "Calculate", "Sekha kabusha","Emuva","Imitha","Kilogram"};

        public string getTitle()
        {
            return Arrayname[0];
        }

        public string getCalcFor()
        {
            return Arrayname[1];
        }

        public string getAdult()
        {
            return Arrayname[2];
        }

        public string getChildren()
        {
            return Arrayname[3];
        }

        public string getHeight()
        {
            return Arrayname[4];
        }

        public string getWeight()
        {
            return Arrayname[5];
        }

        public string getCalc()
        {
            return Arrayname[6];
        }

        public string getReset()
        {
            return Arrayname[7];
        }

        public string getBack()
        {
            return Arrayname[8];
        }

        public string getMetre()
        {
            return Arrayname[9];
        }


            public string getKG()
        {
            return Arrayname[10];
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

