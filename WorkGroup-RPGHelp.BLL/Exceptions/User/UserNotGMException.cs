using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.BLL.Exceptions.User
{
    public class UserNotGMException : UserPermisionDenyException
    {
        public UserNotGMException() : base("User not found")
        {
        }
        public UserNotGMException(string message) : base(message)
        {
        }
    }
}
