using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Models.CharacteresDto
{
    public class CharactereIndexDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int IdRace { get; set; }
        public int Level { get; set; }
        public int XP { get; set; }
        public int UserId { get; set; }
        public Users? Users { get; set; }
        public int? CampagnId { get; set; }
        public Campagn? Campagns { get; set; }
    }
}
