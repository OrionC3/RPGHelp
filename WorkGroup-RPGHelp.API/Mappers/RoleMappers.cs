using WorkGroup_RPGHelp.API.Models.RolesDto;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Mappers
{
    public static class RoleMappers
    {
        public static RoleIndexDto ToRoleIndexDto(this Role role)
        {
            return new RoleIndexDto
            {
                Name = role.Name,
            };
        }
    }
}
