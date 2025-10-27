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
            return _entities.Include(u => u.Role).FirstOrDefault(e => e.Email == email);
        }

        public Users? GetCompletUser(int userId)
        {
            var user = _entities
            .Include(u => u.Role)
            .Include(u => u.Characteres)
            .Include(u => u.Campagns
            .Where(c => c.IdGM == u.Id))
            
            .FirstOrDefault(e => e.Id == userId);

            return user;
        }
        public void SignUpCampagn(Users user, Campagn campagn)
        {
            user.Campagns.Add(campagn);
            _context.SaveChanges();
        }

        public void SignOutCampagn(Users user, Campagn campagn)
        {
            _entities.Attach(user);
            _entities.Entry(user).Collection(u => u.Campagns).Load();
            user.Campagns.Remove(campagn);
            _context.SaveChanges();
        }

        public bool CharactereIsPlaying(Users user, int campagnId)
        {
            return _entities.Where(u => u.Id == user.Id).SelectMany(u => u.Campagns).Any(c => c.Id == campagnId);      
        }
    }
}