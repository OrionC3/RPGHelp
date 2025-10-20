using System.ComponentModel.DataAnnotations;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Models.RaceDto
{
    public class BonusRacialFormDto
    {
        [Required]
        [MaxLength(20)]
        public string BonusName { get; set; }

        [Required]
        [Range(0 , 5)]
        public int BonusValue { get; set; }

        [Required]
        [MaxLength(20)]
        public string MalusName { get; set; }

        [Required]
        [Range(-5, 0)]
        public int MalusValue { get; set; }
    }
}
