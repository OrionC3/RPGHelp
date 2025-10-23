using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.DL.Entities
{
    public class Spell
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Level { get; set; }
        public string? Description { get; set; }
        public List<Race> Races { get; set; } = [];
    }
}
