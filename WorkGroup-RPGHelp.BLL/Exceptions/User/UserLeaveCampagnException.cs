using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.BLL.Exceptions.User
{
    public class UserLeaveCampagnException : UserPermisionDenyException
    {
        public UserLeaveCampagnException() : base ("User can't not leave the campagn")
        {
        }
        public UserLeaveCampagnException(string message) : base(message)
        {
        }
    }
}
