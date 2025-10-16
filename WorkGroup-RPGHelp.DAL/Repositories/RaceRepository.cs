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
    public class RaceRepository : BaseRepository<Race>, IRaceRepository
    {
        public RaceRepository(RPGHelpContext context) : base(context) { }
    public IEnumerable<Race> GetRaces(int page = 0, Func<Race, bool>? predicate = null)
        {
            IEnumerable<Race> query = _entities.Include(r => r.BonusRacial);

            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            return query.OrderBy(r => r.Id)
                        .Skip(page * 10)
                        .Take(10);
        }

        public Race? GetById(int id)
        {
            Race query = _entities.Include(r => r.BonusRacial).FirstOrDefault(r => r.Id == id);
            return query;
        }

        public Race? GetByName(string name)
        {
            return null;
        }
    }
}
