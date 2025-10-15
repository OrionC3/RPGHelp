using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.BLL.Exceptions
{
    public class RPGHelpException : Exception
    {
        public int StatusCode { get; set; }
        public Object Content { get; set; } = null!;

        public RPGHelpException(int status, Object content)
        {
            StatusCode = status;
            Content = content;
        }
    }
}
