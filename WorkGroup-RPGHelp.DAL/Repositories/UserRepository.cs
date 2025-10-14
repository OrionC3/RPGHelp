using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.DL.Entities;
using WorkGroup_RPGHelp.DAL.Repositories.Interfaces;
using WorkGroup_RPGHelp.DAL.Contexts;

namespace WorkGroup_RPGHelp.DAL.Repositories
{
    public class UserRepository : BaseRepository<Users>, IUserRepository
    {
        public UserRepository(RPGHelpContext context) : base(context)
        {
        }

        public IEnumerable<Users> GetUsers(int page = 0, Func<Users, bool>? predicate = null)
        {
            IEnumerable<Users> query = _entities;

            if(predicate != null)
            {
                query = query.Where(predicate);
            }
            return query
                .OrderBy(p => p.Id)
                .Skip(page * 10)
                .Take(10);
        }
        public Users? GetByEmail(string email)
        {
            return _entities.FirstOrDefault(e => e.Email == email);
        }
    }
}