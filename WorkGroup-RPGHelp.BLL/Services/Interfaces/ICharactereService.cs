using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.BLL.Services.Interfaces
{
    public interface ICharactereService
    {
        IEnumerable<Charactere> GetCharacteres(int page = 0);
        IEnumerable<Charactere> GetCharacteresByUserId(int userId, int page = 0);
        Charactere GetCharactereById(int id);
        Charactere GetCharactereByName(string name);
        void Add(Charactere charactere);
        void Update(int id, Charactere charactere);
        void Delete(int id);
        void SignUpCampagn(int charactereId, int campagnId);
    }
}
