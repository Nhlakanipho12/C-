using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyForce_Sport_Management_System
{
    class RestrictUser
    {
        public bool status;
        public RestrictUser()
        {
            status = false;
        }
    }

    class coach : RestrictUser
    {
        public coach():base()
        {
            this.status = false;
        }
    }

    class student : RestrictUser
    {
        public student()
        {
            this.status = false;
        }
    }


}
