using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.BLL.Services.Interfaces
{
    public interface ICampagnService
    {
        IEnumerable<Campagn> GetCampagns(int page = 0);
        Campagn GetCampagnById(int id);
        Campagn GetCampagnByName(string name);
        void Add(Campagn campagn, int userid);
        void Update(int id, Campagn campagn);
        void Delete(int id);
        void ChangeGM(int oldGMId, int newGMId, int campagnId);
    }
}
