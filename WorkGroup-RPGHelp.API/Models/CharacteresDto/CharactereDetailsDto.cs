using WorkGroup_RPGHelp.API.Models.RaceDto;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Models.CharacteresDto
{
    public class CharactereDetailsDto
    {
        public string Name { get; set; } = null!;
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
        public int RaceId { get; set; }
        public RaceIndexDto? RaceIndexDto { get; set; }

    }
}
