using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.DAL.Contexts;
using WorkGroup_RPGHelp.DAL.Repositories.Interfaces;
using WorkGroup_RPGHelp.DL.Entities;


namespace WorkGroup_RPGHelp.DAL.Repositories
{
    public class SpellRepository : BaseRepository<Spell>, ISpellRepository
    {
        public SpellRepository(RPGHelpContext context) : base (context)
        {
        }
        public IEnumerable<Spell> GetSpells(int page = 0, Func<Spell, bool>? predicate = null)
        {
            IEnumerable<Spell> query = _entities;

            if(predicate != null)
            {
                query = query.Where(predicate);
            }
            return query
                .OrderBy(s => s.Id)
                .Skip(page * 10)
                .Take(10);
        }
    }
}
