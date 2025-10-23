using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Models.SpellsDto
{
    public class SpellIndexDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        //public List<Race> Races { get; set; } = [];
    }
}
