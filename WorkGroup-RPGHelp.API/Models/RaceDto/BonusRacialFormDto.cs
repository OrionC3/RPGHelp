using System.ComponentModel.DataAnnotations;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Models.RaceDto
{
    public class BonusRacialFormDto
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [Range(0 , 5)]
        public int Bonus { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name2 { get; set; }

        [Required]
        [Range(-5, 0)]
        public int Malus { get; set; }
    }
}
