using WorkGroup_RPGHelp.API.Models.UsersDto;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Mappers
{
    public static class UserMappers
    {
        public static UserIndexDto ToUserIndexDto(this Users u)
        {
            return new UserIndexDto()
            {
                Email = u.Email,
            };
        }
        public static UserSelfDto ToUserSelfIndexDto(this Users u)
        {
            return new UserSelfDto()
            {
                Email = u.Email,
                Role = u.Role.Select(u => u.ToRoleIndexDto()).ToList(),
                Characteres = u.Characteres.Select(u => u.ToCharactereIndexDto()).ToList(),
                Campagns = u.Campagns.Select(u => u.ToCampagnIndexDto()).ToList(),
            };
        }

        public static Users ToUser(this UserFormDto u)
        {
            return new Users()
            {
                Email = u.Email,
                Password = u.Password,
            };
        }
    }
}
