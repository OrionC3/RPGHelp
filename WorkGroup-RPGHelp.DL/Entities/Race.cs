using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.DL.Entities
{
    public class Race
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TravelSpeed { get; set; }
        public BonusRacial BonusRacial { get; set; }
        public int BonusRacialId { get; set; }
    }
}
