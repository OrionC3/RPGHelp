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
