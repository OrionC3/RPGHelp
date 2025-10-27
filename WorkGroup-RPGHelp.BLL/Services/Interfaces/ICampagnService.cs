using Azure;
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
        void Update(int id, Campagn campagn, int userId);
        void Delete(int id, int userId);
        void ChangeGM(int oldGMId, int newGMId, int campagnId);
        IEnumerable<Users> GetUsersCampagn(int campagnId, int page = 0);
        IEnumerable<Charactere> GetCharacteresCampagn(int campagnId, int page = 0);
    }
}
