using System.ComponentModel.DataAnnotations;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Models.CharacteresDto
{
    public class CharactereFormDto
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; } = null!;
        public int IdRace { get; set; }
        [Required]
        [Range (0, Int32.MaxValue, ErrorMessage = "Invalid must be greater then 0")]
        public int PVMax { get; set; }
        [Required]
        public int PVCurrent { get; set; }
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Invalid must be greater then 0")]
        public int Strength { get; set; }
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Invalid must be greater then 0")]
        public int Dexterity { get; set; }
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Invalid must be greater then 0")]
        public int Constitution { get; set; }
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Invalid must be greater then 0")]
        public int Intelligence { get; set; }
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Invalid must be greater then 0")]
        public int Wisdom { get; set; }
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Invalid must be greater then 0")]
        public int Charisma { get; set; }
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Invalid must be greater then 0")]
        public int Defence { get; set; }
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Invalid must be greater then 0")]
        public int Initiative { get; set; }
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Invalid must be greater then 0")]
        public int BaseAttackBonus { get; set; }
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Invalid must be greater then 0")]
        public int FortitudeSave { get; set; }
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Invalid must be greater then 0")]
        public int ReflexeSave { get; set; }
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Invalid must be greater then 0")]
        public int WillpowerSave { get; set; }
        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "Invalid must be greater then 1")]
        public int Level { get; set; }
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Invalid must be greater then 0")]
        public int XP { get; set; }
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Invalid must be greater then 0")]
        public int Speed { get; set; }
    }
}
