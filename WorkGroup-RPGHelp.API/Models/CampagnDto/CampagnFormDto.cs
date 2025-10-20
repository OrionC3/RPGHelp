using System.ComponentModel.DataAnnotations;

namespace WorkGroup_RPGHelp.API.Models.CampagnDto
{
    public class CampagnFormDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;
    }
}
