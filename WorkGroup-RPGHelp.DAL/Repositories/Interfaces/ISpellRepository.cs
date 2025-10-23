using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.DAL.Repositories.Interfaces
{
    public interface ISpellRepository : IBaseRepository<Spell>
    {
        IEnumerable<Spell> GetSpells(int page = 0, Func<Spell, bool>? predicate = null);
    }
}