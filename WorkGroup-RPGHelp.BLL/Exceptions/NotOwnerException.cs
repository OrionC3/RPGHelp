using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.BLL.Exceptions
{
    public class NotOwnerException : RPGHelpException
    {
        public NotOwnerException() : base(501, "You are not the owner")
        {
        }

        public NotOwnerException(Object content) : base(501, content)
        {
        }
    }
}
