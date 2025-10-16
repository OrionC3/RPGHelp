using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.DL.Entities
{
    public class BonusRacial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Bonus { get; set; }
        public string Name2 { get; set; }
        public int Malus { get; set; }
        public Race Race { get; set; }
    }
}
