using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.BLL.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<Users> GetUsers(int page = 0);
        Users GetUser(int id);
        void Add(Users user);
        void Update(int id, Users user);
        void Delete(int id);
        Users Login(string email, string password);
        void JoinCampagn(int userId, int campagnId);
        void LeaveCampagn(int userId, int campagnId);
        void InvitCampagn(int userId, int campagnId, int IdGM);
    }
}
