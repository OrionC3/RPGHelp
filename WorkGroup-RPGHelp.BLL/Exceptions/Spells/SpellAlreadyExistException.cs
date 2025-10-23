using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.BLL.Exceptions.Spells
{
    public class SpellAlreadyExistException : AlreadyExistException
    {
        public SpellAlreadyExistException() : base ("Spell already exist")
        {
        }
        public SpellAlreadyExistException(object content) : base(content)
        {
        }
    }
}
