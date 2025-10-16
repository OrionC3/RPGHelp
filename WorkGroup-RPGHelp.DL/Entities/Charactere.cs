using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.DL.Entities
{
    public class Charactere
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int IdRace { get; set; }
        public int PVMax { get; set; }
        public int PVCurrent { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Defence { get; set; }
        public int Initiative { get; set; }
        public int BaseAttackBonus { get; set; }
        public int FortitudeSave { get; set; }
        public int ReflexeSave { get; set; }
        public int WillpowerSave { get; set; }
        public int Level { get; set; }
        public int XP { get; set; }
        public int Speed { get; set; }
        public int UserId { get; set; }
        public Users? Users { get; set; }
        public int? CampagnId { get; set; }
        public Campagn? Campagns { get; set; }

    }
}
