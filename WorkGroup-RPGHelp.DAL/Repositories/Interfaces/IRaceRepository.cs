using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.DAL.Repositories.Interfaces
{
    public interface IRaceRepository : IBaseRepository<Race>
    {
        IEnumerable<Race> GetRaces(int page = 0, Func<Race, bool>? predicate = null);
        Race GetById(int id);
        Race GetByName(string name);
    }
}
