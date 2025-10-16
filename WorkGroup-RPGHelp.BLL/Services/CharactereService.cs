using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.BLL.Services.Interfaces;
using WorkGroup_RPGHelp.DAL.Repositories.Interfaces;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.BLL.Services
{
    public class CharactereService : ICharactereService
    {
        private readonly ICharactereRepository _charactereRepository;
        private readonly IUserRepository _userRepository;

        public CharactereService(ICharactereRepository charactereRepository, IUserRepository userRepository)
        {
            _charactereRepository = charactereRepository;
            _userRepository = userRepository;
        }
        public void Add(Charactere charactere)
        {
            _charactereRepository.Add(charactere);
        }

        public void Delete(int id)
        {
            Charactere? charactere = _charactereRepository.FindOne(id);
            if (charactere == null)
            {
                throw new Exception($"charactere with {id} doesn't exist");
            }
            _charactereRepository.Delete(charactere);
        }

        public Charactere GetCharactereById(int id)
        {
            Charactere? charactere = _charactereRepository.FindOne(c => c.Id == id);
            if (charactere == null)
            {
                throw new Exception($"charactere with {id} not found");
            }
            return charactere;
        }

        public Charactere GetCharactereByName(string name)
        {
            Charactere? charactere = _charactereRepository.FindOne(c => c.Name == name);
            if (charactere == null)
            {
                throw new Exception($"Campagn with {name} not found");
            }
            return charactere;
        }

        public IEnumerable<Charactere> GetCharacteres(int page = 0)
        {
            return _charactereRepository.GetCharacteres(page);
        }
        public IEnumerable<Charactere> GetCharacteresByUserId(int userId, int page = 0)
        {
            return _charactereRepository.GetCharacteresByUserId(userId, page);
        }

        public void Update(int id, Charactere charactere)
        {
            Charactere? c = _charactereRepository.FindOne(c => c.Id == id);
            if (c == null)
            {
                throw new Exception($"Campagn with {id} not found");
            }

            if (charactere.Id > 0)
            {
                c.Id = charactere.Id;
            }
            c.Name = charactere.Name;

            _charactereRepository.Update(c);
        }
        public void SignUpCampagn(int charactereId, int campagnId)
        {
            Charactere? c = _charactereRepository.FindOne(c => c.Id == charactereId);
            if (c == null)
            {
                throw new Exception($"Campagn with {charactereId} not found");
            }
            //TO DO, check user is in table campagnusers
            Users? u = _userRepository.FindOne(c.UserId);
            bool isPlaying = _userRepository.CharactereIsPlaying(u, campagnId);

            if (isPlaying)
            {
                //verify charactere is not in the campagn
                if(c.CampagnId == null)
                {
                    //sign up
                    c.CampagnId = campagnId;
                    Console.WriteLine("charactere sign up the campagn");
                }
                else
                {
                    // else sign out
                    c.CampagnId = null;
                    Console.WriteLine("charactere sign out/quit the campagn");
                }
                _charactereRepository.Update(c);

            }
            else
            {
                throw new Exception($"User is not playing in the campagn {campagnId}");
            }
        }
    }
}
