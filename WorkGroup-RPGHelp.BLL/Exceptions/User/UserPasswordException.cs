using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.BLL.Exceptions.User
{
    public class UserPasswordException : RPGHelpException
    {
        public UserPasswordException() : base(409, "Error : Try again")
        {
        }
        public UserPasswordException(string message) : base(409, message)
        {
        }
    }
}
