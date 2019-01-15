using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VO2_Max.Classes
{
    class Language
    {
        public string form, lingo;
        public string[] Arrayname = new string[100];

        public Language(string Rform,string Rlingo)
        {
            form = Rform;
            lingo = Rlingo;
        }


       //Afrikaans
        string[] ArrSignInAfrikaans = { "Gebruikersnaam:", "Wagwoord:   ", "Teken aan", "Registreer", "Klik hier  ", "Uitgaan" , "volg ons:" };
        //English
        string[] ArrSignInEnglish = { " Username :  ", " Password:   ", "Login",  "  Sign Up   ", " Click Here ", "Exit", "Follow us: " };
        //Zulu
        string[] ArrSignInZulu = { "Umsebenzisi :", "Iphasiwedi :  ", "Ngena", "Bhalisela", "Chofoza lapha", "Phuma","Silandele"};
        public string getUsername()
        {
            
            return Arrayname[0];
        }

        public string getPassword()
        {
            return Arrayname[1];
        }

        public string getLogin()
        {
            return Arrayname[2];
        }

        public string getSignUp()
        {
            return Arrayname[3];
        }

        public string getClickHere()
        {
            return Arrayname[4];
        }

        public string getExit()
        {
            return Arrayname[5];
        }

        public string getFollowUs()
        {
            return Arrayname[6];
        }

        public void setLingo(Int32 check)
        {
            int i = check;

            switch (i)
            {
                case 1: ArrSignInAfrikaans.CopyTo(Arrayname, 0);
                    break;
        
                case 2: ArrSignInEnglish.CopyTo(Arrayname, 0);
                    break;

                case 3:
                    ArrSignInZulu.CopyTo(Arrayname, 0);
                    break;

            }
                
        }
        }

    }

