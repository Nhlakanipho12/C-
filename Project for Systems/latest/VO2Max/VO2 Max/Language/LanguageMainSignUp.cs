using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO2_Max.Language
{
    class LanguageMainSignUp
    {
        public string[] Arrayname = new string[100];

        public LanguageMainSignUp()
        {

        }

        string[] ArrSignUpAfrikaans = { "Naam", "Van", "ID-Nommer", "Kontak No", "Epos adres", "Hoogte", "Afrigter", "Voedingsleer", "Skep wagwoord", "Nuwe wagwoord", "Bevestig wagwoord", "Registreer", "Volg ons", "Klik hier", "Stap 1", "Stap 2", "Terug" };
        string[] ArrSignUpEnglish = { "Name :", "Surname :", "ID Number :", "Contact No", "Email Address", "Coach", "Nutritionist", "Office address", "Create Password", "New password", "Confirm password", "Sign up", "Follow us", "Click here", "Step 1", "Step 2", "Back" };
        string[] ArrSignUpZulu = { "Igama", "isibongo", "inombolo Id", "inombolo yocingo", "imeyili", "Translation", "Translation", "ihhovisi", "Akha Iphasiwedi", "Iphasiwedi Entsha", "Qinisekisa Iphasiwedi", "bhalisela", "Silandele", "Chofoza lapha", "Isinyathelo 1", "Isinyathelo 2", "Emuva" };

        public void setLingo(Int32 check)
        {
            int i = check;

            switch (i)
            {
                case 1:
                    ArrSignUpAfrikaans.CopyTo(Arrayname, 0);
                    break;

                case 2:
                    ArrSignUpEnglish.CopyTo(Arrayname, 0);
                    break;

                case 3:
                    ArrSignUpZulu.CopyTo(Arrayname, 0);
                    break;

            }

        }

        public string getName()
        {

            return Arrayname[0];
        }
        public string getSurname()
        {

            return Arrayname[1];
        }
        public string getIDNumber()
        {

            return Arrayname[2];
        }
        public string getContactNumber()
        {

            return Arrayname[3];
        }
        public string getCEmailAddress()
        {

            return Arrayname[4];
        }
        public string getHeight()
        {

            return Arrayname[5];
        }
        public string getWWeight()
        {

            return Arrayname[6];
        }
        public string getOfficeAdress()
        {

            return Arrayname[7];
        }
        public string getCreatePass()
        {

            return Arrayname[8];
        }
        public string getNewPass()
        {

            return Arrayname[9];
        }
        public string getConfirmPass()
        {

            return Arrayname[10];
        }
        public string getSignUp()
        {

            return Arrayname[11];
        }
        public string getFollow()
        {

            return Arrayname[12];
        }
        public string getClickhere()
        {

            return Arrayname[13];
        }
        public string getStep1()
        {

            return Arrayname[14];
        }
        public string getStep2()
        {

            return Arrayname[15];
        }
        public string getBack()
        {

            return Arrayname[16];
        }
    }
}

