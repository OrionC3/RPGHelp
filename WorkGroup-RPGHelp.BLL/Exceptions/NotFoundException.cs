using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.BLL.Exceptions
{
    public class NotFoundException : RPGHelpException
    {
        public NotFoundException(Object content) : base (404, content)
        {
        }
    }
}
