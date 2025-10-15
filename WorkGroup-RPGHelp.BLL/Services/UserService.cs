using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.BLL.Services.Interfaces;
using WorkGroup_RPGHelp.DL.Entities;
using WorkGroup_RPGHelp.DAL.Repositories.Interfaces;
using Isopoh.Cryptography.Argon2;
using WorkGroup_RPGHelp.BLL.Exceptions;
using WorkGroup_RPGHelp.BLL.Exceptions.User;

namespace WorkGroup_RPGHelp.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
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
                throw new UserNotFoundException($"Email {user.Email} already exist.");
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
            return u;
        }

    }
}
