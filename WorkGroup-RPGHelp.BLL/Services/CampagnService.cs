using Isopoh.Cryptography.Argon2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.BLL.Exceptions.Campagn;
using WorkGroup_RPGHelp.BLL.Exceptions.User;
using WorkGroup_RPGHelp.BLL.Services.Interfaces;
using WorkGroup_RPGHelp.DAL.Repositories.Interfaces;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.BLL.Services
{
    public class CampagnService : ICampagnService
    {
        private readonly ICampagnRepository _campagnRepository;

        public CampagnService(ICampagnRepository campagnRepository)
        {
            _campagnRepository = campagnRepository;
        }
        public void Add(Campagn campagn, int userid)
        {
            campagn.IdGM = userid;
            _campagnRepository.Add(campagn);
        }


        public void Delete(int id, int userId)
        {
            Campagn? campagn = _campagnRepository.FindOne(id);
            if (campagn == null) 
            {
                throw new CampagnNotFoundException($"Campagn with {id} doesn't exist");
            }
            if(campagn.IdGM != userId)
            {
                throw new Exception("You uare not owner");
            }
            _campagnRepository.Delete(campagn);
        }

        public Campagn GetCampagnById(int id)
        {
            Campagn? campagn = _campagnRepository.FindOne(c => c.Id == id);
            if(campagn == null)
            {
                throw new CampagnNotFoundException($"Campagn with {id} not found");
            }
            return campagn;
        }

        public IEnumerable<Campagn> GetCampagnByUserId(int userId, int page = 0)
        {
            IEnumerable<Campagn> campagn = _campagnRepository.GetCampagnByUserId(userId, page);
            return campagn;
        }

        public Campagn GetCampagnByName(string name)
        {
            Campagn? campagn = _campagnRepository.FindOne(c => c.Name == name);
            if (campagn == null)
            {
                throw new CampagnNotFoundException($"Campagn with {name} not found");
            }
            return campagn;
        }

        public IEnumerable<Campagn> GetCampagns(int page = 0)
        {
            return _campagnRepository.GetCampagns(page);
        }

        public void Update(int id, Campagn campagn, int userId)
        {
            Campagn? c = _campagnRepository.FindOne(c => c.Id == id);
            if(c == null)
            {
                throw new CampagnNotFoundException($"Campagn with {id} not found");
            }
            if(campagn.IdGM != userId)
            {
                throw new Exception("You are not owner");
            }

            if(campagn.Id > 0)
            {
                c.Id = campagn.Id;
            }
            c.Name = campagn.Name;

            _campagnRepository.Update(c);
        }
        public void ChangeGM(int oldGMId, int newGMId, int campagnId)
        {
            Campagn? campagn = _campagnRepository.FindOne(campagnId);
            if (campagn == null) 
            {
                throw new CampagnNotFoundException($"Campagn with {campagnId} doesn't exist");
            }
            if (campagn.IdGM != oldGMId) 
            {
                throw new UserNotGMException();
            }
            campagn.IdGM = newGMId;
            _campagnRepository.Update(campagn);
        }
        public IEnumerable<Charactere> GetCharacteresCampagn(int campagnId, int page = 0)
        {
            return _campagnRepository.GetCharacteresCampagn(campagnId, page);
        }

        public IEnumerable<Users> GetUsersCampagn(int campagnId, int page = 0)
        {
            return _campagnRepository.GetUsersCampagn(campagnId, page);
        }
    }
}
