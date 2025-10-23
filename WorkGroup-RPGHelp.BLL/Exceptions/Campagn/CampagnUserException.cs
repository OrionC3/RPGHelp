using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.BLL.Exceptions.Campagn
{
    public class CampagnUserException : RPGHelpException
    {
        public CampagnUserException() : base (400, "User is not playing in the campagn")
        {
            
        }
        public CampagnUserException(object content) : base(400, content)
        {
        }
    }
}
