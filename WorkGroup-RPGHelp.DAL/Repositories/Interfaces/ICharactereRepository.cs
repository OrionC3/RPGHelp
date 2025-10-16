using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.DAL.Repositories.Interfaces
{
    public interface ICharactereRepository: IBaseRepository<Charactere>
    {
        IEnumerable<Charactere> GetCharacteres(int page = 0, Func<Charactere, bool>? predicate = null);
        IEnumerable<Charactere> GetCharacteresByUserId(int userId, int page = 0, Func<Charactere, bool>? predicate = null);
    }
}
