using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.BLL.Exceptions
{
    public class UserPermisionDenyException : RPGHelpException
    {
        public UserPermisionDenyException(object content) : base(401, content)
        {
        }
    }
}
