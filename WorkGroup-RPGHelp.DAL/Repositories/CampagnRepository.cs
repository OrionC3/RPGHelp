using Azure;
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
    public class CampagnRepository : BaseRepository<Campagn>, ICampagnRepository
    {
        public CampagnRepository(RPGHelpContext context) : base(context)
        {
        }

        public IEnumerable<Campagn> GetCampagns(int page = 0, Func<Campagn, bool>? predicate = null)
        {
            IEnumerable<Campagn> query = _entities;

            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            return query
                .OrderBy(p => p.Id)
                .Skip(page * 10)
                .Take(10);
        }

        public IEnumerable<Campagn> GetCampagnByUserId(int userId, int page = 0, Func<Campagn, bool>? predicate = null)
        {
            IEnumerable<Campagn> query = _entities.Where(c => c.IdGM == userId);

            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            return query
                .OrderBy(p => p.Id)
                .Skip(page * 10)
                .Take(10);
        }

        public IEnumerable<Users> GetUsersCampagn(int campagnId, int page = 0)
        {
            IEnumerable<Users> query = _entities.Where(c => c.Id == campagnId).SelectMany(c => c.Users);
            return query
                .OrderBy(p => p.Id)
                .Skip(page * 10)
                .Take(10);
        }

        public IEnumerable<Charactere> GetCharacteresCampagn(int campagnId, int page = 0)
        {
            IEnumerable<Charactere> query = _entities
                .Include(c => c.Characteres)
                .ThenInclude(ch => ch.Race)
                .ThenInclude(r => r.BonusRacial)
                .Where(c => c.Id == campagnId)
                .SelectMany(c => c.Characteres);

            return query
                .OrderBy(p => p.Id)
                .Skip(page * 10)
                .Take(10);
        }
    }
}
