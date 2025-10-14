using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.DAL.Repositories.Interfaces
{
    public interface IUserRepository: IBaseRepository<Users>
    {
        IEnumerable<Users> GetUsers(int page = 0, Func<Users, bool>? predicate = null);
        Users GetByEmail(string email);
    }
}
