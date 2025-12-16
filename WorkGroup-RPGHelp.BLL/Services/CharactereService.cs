using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.BLL.Exceptions;
using WorkGroup_RPGHelp.BLL.Exceptions.Campagn;
using WorkGroup_RPGHelp.BLL.Exceptions.Character;
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
        public Charactere Add(Charactere charactere)
        {
            return _charactereRepository.Add(charactere);
        }

        public void Delete(int id, int userId)
        {
            Charactere? charactere = _charactereRepository.FindOne(id);
            if (charactere == null)
            {
                throw new CharacterNotFoundException($"charactere with {id} doesn't exist");
            }

            if(charactere.Id == userId)
            {
                throw new NotOwnerException($"You are not owner");
            }
            _charactereRepository.Delete(charactere);
        }

        public Charactere GetCharactereById(int id)
        {
            Charactere? charactere = _charactereRepository.GetCharacteresById(id);
            if (charactere == null)
            {
                throw new CharacterNotFoundException($"charactere with {id} not found");
            }
            return charactere;
        }

        public Charactere GetCharactereByName(string name)
        {
            Charactere? charactere = _charactereRepository.FindOne(c => c.Name == name);
            if (charactere == null)
            {
                throw new CampagnNotFoundException($"Campagn with {name} not found");
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

        public void Update(int id, Charactere charactere, int userId)
        {
            Charactere? c = _charactereRepository.FindOne(c => c.Id == id);
            if (c == null)
            {
                throw new CharacterNotFoundException($"Character with {id} not found");
            }

            if(charactere.UserId != userId)
            {
                throw new NotOwnerException("You are not owner");
            }

            if (charactere.Id > 0)
            {
                c.Id = charactere.Id;
            }

            c.Name = charactere.Name;
            c.PVMax = charactere.PVMax;
            c.PVCurrent = charactere.PVCurrent;
            c.Strength = charactere.Strength;
            c.Dexterity = charactere.Dexterity;
            c.Constitution = charactere.Constitution;
            c.Intelligence = charactere.Intelligence;
            c.Wisdom = charactere.Wisdom;
            c.Charisma = charactere.Charisma;
            c.Defence = charactere.Defence;
            c.Initiative = charactere.Initiative;
            c.BaseAttackBonus = charactere.BaseAttackBonus;
            c.FortitudeSave = charactere.FortitudeSave;
            c.ReflexeSave = charactere.ReflexeSave;
            c.WillpowerSave = charactere.WillpowerSave;
            c.Level = charactere.Level;
            c.XP = charactere.XP;
            c.Speed = charactere.Speed;
            c.RaceId = charactere.RaceId;
            c.UserId = charactere.UserId;

            _charactereRepository.Update(c);
        }
        public void SignUpCampagn(int charactereId, int campagnId)
        {
            Charactere? c = _charactereRepository.FindOne(c => c.Id == charactereId);
            if (c == null)
            {
                throw new CampagnNotFoundException($"Campagn with {charactereId} not found");
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
                throw new CampagnUserException($"User is not playing in the campagn {campagnId}");
            }
        }

        public long Count(int userId)
        {
            return _charactereRepository.Count((c) => c.UserId == userId);
        }
    }
}
