using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WorkGroup_RPGHelp.API.Models.UsersDto
{
    public class UserFormDto
    {
        [Required]
        [MaxLength(150)]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
