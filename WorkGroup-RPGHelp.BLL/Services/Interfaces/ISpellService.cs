using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.BLL.Services.Interfaces
{
    public interface ISpellService
    {
        IEnumerable<Spell> GetSpells(int page = 0);
        Spell GetSpell(int id);
        void Add(Spell spell);
        void Update(int id, Spell spell);
        void Delete(int id);
    }
}
