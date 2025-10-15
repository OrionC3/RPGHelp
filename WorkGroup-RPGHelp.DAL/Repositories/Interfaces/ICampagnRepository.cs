using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.DAL.Repositories.Interfaces;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.DAL.Repositories.Interfaces
{
    public interface ICampagnRepository : IBaseRepository<Campagn>
    {
        IEnumerable<Campagn> GetCampagns(int page = 0, Func<Campagn, bool>? predicate = null);
    }
}
