using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.BLL.Exceptions
{
    public class AlreadyExistException : RPGHelpException
    {
        public AlreadyExistException() : base (409, "Already exist")
        {
            
        }
        public AlreadyExistException(object content) : base (409, content)
        {
        }
    }
}
