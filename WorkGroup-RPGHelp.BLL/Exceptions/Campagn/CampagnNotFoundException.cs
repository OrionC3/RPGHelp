using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.BLL.Exceptions.Campagn
{
    public class CampagnNotFoundException : NotFoundException
    {
        public CampagnNotFoundException() : base("Campang not found")
        {
        }

        public CampagnNotFoundException(string message) : base(message)
        {
        }
    }
}
