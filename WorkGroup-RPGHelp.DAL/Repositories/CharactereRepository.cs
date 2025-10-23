using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.DAL.Contexts;
using WorkGroup_RPGHelp.DAL.Repositories.Interfaces;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.DAL.Repositories
{
    public class CharactereRepository : BaseRepository<Charactere>, ICharactereRepository
    {
        public CharactereRepository(RPGHelpContext context) : base(context)
        {
        }

        public IEnumerable<Charactere> GetCharacteres(int page = 0, Func<Charactere, bool>? predicate = null)
        {
            IEnumerable<Charactere> query = _entities.Include(c => c.Race).ThenInclude(r => r.BonusRacial);

            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            return query
                .OrderBy(p => p.Id)
                .Skip(page * 10)
                .Take(10);
        }

        public IEnumerable<Charactere> GetCharacteresByUserId(int userId, int page = 0, Func<Charactere, bool>? predicate = null)
        {
            IEnumerable<Charactere> query = _entities.Include(c => c.Race).ThenInclude(r => r.BonusRacial).Where(p => p.UserId == userId);

            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            return query
                .OrderBy(p => p.Id)
                .Skip(page * 10)
                .Take(10);
        }
    }
}
