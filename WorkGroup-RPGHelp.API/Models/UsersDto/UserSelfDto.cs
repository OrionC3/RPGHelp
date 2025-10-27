using WorkGroup_RPGHelp.API.Models.CampagnDto;
using WorkGroup_RPGHelp.API.Models.CharacteresDto;
using WorkGroup_RPGHelp.API.Models.RolesDto;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Models.UsersDto
{
    public class UserSelfDto
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public List<RoleIndexDto> Role { get; set; } = [];
        public List<CharactereIndexDto> Characteres { get; set; } = [];
        public List<CampagnIndexDto> Campagns { get; set; } = [];
    }
}
