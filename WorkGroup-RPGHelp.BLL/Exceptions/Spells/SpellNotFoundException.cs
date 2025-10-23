using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.BLL.Exceptions.Spells
{
    public class SpellNotFoundException : NotFoundException
    {
        public SpellNotFoundException() : base("Spell not found")
        {  
        }
        public SpellNotFoundException(string message) : base(message)
        {
        }
    }
}
