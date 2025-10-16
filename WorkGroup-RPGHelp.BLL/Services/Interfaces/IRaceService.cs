using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.BLL.Services.Interfaces
{
    public interface IRaceService
    {
        IEnumerable<Race> GetRaces(int page = 0);
        Race GetRace(int id);
        void Add(Race race);
        void Update(int id, Race race);
        void Delete(int id);
    }
}
