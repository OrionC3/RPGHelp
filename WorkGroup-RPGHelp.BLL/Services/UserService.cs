using Azure;
using Isopoh.Cryptography.Argon2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.BLL.Services.Interfaces;
using WorkGroup_RPGHelp.DAL.Repositories;
using WorkGroup_RPGHelp.DAL.Repositories.Interfaces;
using Isopoh.Cryptography.Argon2;
using WorkGroup_RPGHelp.BLL.Exceptions;
using WorkGroup_RPGHelp.BLL.Exceptions.User;
using WorkGroup_RPGHelp.DL.Entities;
using WorkGroup_RPGHelp.BLL.Exceptions.Campagn;

namespace WorkGroup_RPGHelp.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICampagnRepository _campagnRepository;

        public UserService(IUserRepository userRepository, ICampagnRepository campagnRepository)
        {
            _userRepository = userRepository;
            _campagnRepository = campagnRepository;
        }
        public IEnumerable<Users> GetUsers(int page = 0)
        {
            return _userRepository.GetUsers(page);
        }

        public Users GetUser(int id)
        {
            Users? user = _userRepository.FindOne(id);

            if(user == null)
            {
                throw new UserNotFoundException($"User with id : {id} not found.");
            }
            return user;
        }
        public void Add(Users user)
        {
            if(_userRepository.FindOne(u => u.Email == user.Email) != null)
            {
                throw new UserExistException($"Email {user.Email} already exist.");
            }
            user.Password = Argon2.Hash(user.Password);
            _userRepository.Add(user);
        }

        public void Delete(int id)
        {
            Users? existing = _userRepository.FindOne(id);

            if(existing == null)
            {
                throw new UserNotFoundException($"User with id : {id} not found.");
            }
            _userRepository.Delete(existing);
        }

        public IEnumerable<Users> Getusers(int page = 0)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Users user)
        {
            Users? existing = _userRepository.FindOne(id);
            if (existing == null)
            {
                throw new UserNotFoundException($"User with id : {id} not found.");
            }
            _userRepository.Update(existing);
        }

        public Users Login(string email, string password)
        {
            Users? u = _userRepository.GetByEmail(email);
            if (!Argon2.Verify(u.Password, password))
            {
                throw new UserPasswordException($"Bad request");
            }
            return u;
        }
        // User add himself
        public void SignUpCampagn(int userId, int campagnId)
        {
            Users? user = _userRepository.FindOne(userId);

            if (user == null)
            {
                throw new UserNotFoundException($"User with id {userId} not found");
            }
            Campagn? campagn = _campagnRepository.FindOne(campagnId);
            if (campagn == null)
            {
                throw new CampagnNotFoundException($"Campagn with id {campagnId} not found");
            }

            //test user dans la campagne
            bool hasAlreadyJoinCampagn = _userRepository.CharactereIsPlaying(user, campagn.Id);

            if (hasAlreadyJoinCampagn)
            {
                //true
                if(campagn.IdGM == user.Id)
                {
                    throw new UserLeaveCampagnException($"GM can't not leave the campagn");
                }
                _userRepository.SignOutCampagn(user, campagn);
            }
            else
            {
                //false
                _userRepository.SignUpCampagn(user, campagn);
            }
        }
        // GM add users
        public void SignUpCampagn(int userId, int campagnId, int IdGM)
        {
            Users? user = _userRepository.FindOne(userId);
            if(user == null)
            {
                throw new UserNotFoundException($"User with id {userId} not found");
            }
            Campagn? campagn = _campagnRepository.FindOne(campagnId);
            if(campagn == null)
            {
                throw new CampagnNotFoundException($"Campagn with id {campagnId} not found");
            }
            // test if GM
            if (campagn.IdGM != IdGM)
            {
                throw new ($"User with id {IdGM} is not GM");
            }
            _userRepository.SignUpCampagn(user, campagn);
        }
    }
}
