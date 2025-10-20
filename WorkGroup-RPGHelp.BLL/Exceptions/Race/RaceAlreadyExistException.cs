using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.BLL.Exceptions.Race
{
    public class RaceAlreadyExistException : AlreadyExistException
    {
        public RaceAlreadyExistException() : base ("Name already exist.")
        {
        }

        public RaceAlreadyExistException(object content) : base(content)
        {
        }
    }
}
