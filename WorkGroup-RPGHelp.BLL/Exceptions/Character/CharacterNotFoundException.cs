using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.BLL.Exceptions.Character
{
    public class CharacterNotFoundException : NotFoundException
    {
        public CharacterNotFoundException() : base ("Character not found")
        {
            
        }
        public CharacterNotFoundException(object content) : base(content)
        {
        }
    }
}
