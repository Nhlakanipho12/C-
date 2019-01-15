using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO2_Max.Classes
{
    class PrivacyFirewall
    {
        private string output = "";
        private string input;
        private string[] Alphabets = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z" };

        private void setInput(string input)
        {
            this.input = input;
        }

        private string getOutput()
        {
            return output;
        }

        private void encrypt()
        {
            string hold = "";
            int location = 0;
            string original = input.Substring(6,13);

            for(int k = 0; k <= original.Length; k++)
            {
                location = Convert.ToInt32(input.Substring(k,k+1));
                hold += Alphabets[location];
            }

            output = input.Substring(0, 6) + hold;
        }

        private void Decrypt()
        {
            string hold = "";
            string test = "";

            string encripted = input.Substring(6, 13);

            for(int d = 0; d <= encripted.Length; d++)
            {
                int location = 0;
                test = encripted.Substring(d,d+1);
                while (test != Alphabets[location])
                {
                    location++;
                }

                hold += test;
            }

            output = input.Substring(0,6) + hold;
        }
    }
}
