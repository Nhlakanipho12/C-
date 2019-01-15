using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO2_Max.Classes
{
    class SignUPExceptionhandling
    {

        public bool checkNOTNull(string str)
        {
            if (str != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkID(string id)
        {
            bool turn = false;
  
            int length = id.Count();
            if (length == 12)
                {
                    turn = true;
                }
                else
                {
                    turn = false;
                }

            return turn;
        }

        public bool checkContact(string digits)
        {
            bool turn = false;
           
                int length = digits.Count();
                if (length == 9)
                {
                    turn = true;
                }
                else
                {
                    turn = false;
                }
           
                return turn;
            
        }

      }
    }

