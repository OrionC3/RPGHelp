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
        public string BonusName { get; set; }
        public int BonusValue { get; set; }
        public string MalusName { get; set; }
        public int MalusValue { get; set; }
        public Race Race { get; set; }
    }
}
