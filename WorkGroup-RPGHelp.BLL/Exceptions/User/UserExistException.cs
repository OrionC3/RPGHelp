using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.BLL.Exceptions.User
{
    public class UserExistException : AlreadyExistException
    {
        public UserExistException() : base ("Email already exist")
        {
        }
        public UserExistException(string message) : base (message)
        {
        }
    }
}
