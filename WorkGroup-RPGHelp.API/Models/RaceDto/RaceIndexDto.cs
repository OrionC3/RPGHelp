using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Models.RaceDto
{
    public class RaceIndexDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TravelSpeed { get; set; }
        public BonusRacialIndexDto BonusRacial { get;set; }
    }
}
