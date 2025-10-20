using System.ComponentModel.DataAnnotations;

namespace WorkGroup_RPGHelp.API.Models.RaceDto
{
    public class RaceFormDto
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [Range (0,Int32.MaxValue, ErrorMessage = "Must be greater then 0")]
        public int TravelSpeed { get; set; }
        public BonusRacialFormDto BonusRacialFormDto { get; set; }
    }
}
