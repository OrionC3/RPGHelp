using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.BLL.Exceptions.Race;
using WorkGroup_RPGHelp.BLL.Services.Interfaces;
using WorkGroup_RPGHelp.DAL.Repositories.Interfaces;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.BLL.Services
{
    public class RaceService : IRaceService
    {
        private readonly IRaceRepository _raceRepository;

        public RaceService(IRaceRepository raceRepository)
        {
            _raceRepository = raceRepository;
        }

        public void Add(Race race)
        {
            if(_raceRepository.FindOne(r => r.Name == race.Name) != null)
            {
                throw new RaceAlreadyExistException($"Name {race.Name} already exist.");
            }
            _raceRepository.Add(race);
        }

        public void Delete(int id)
        {
            Race race = _raceRepository.FindOne(i => i.Id == id);
            _raceRepository.Delete(race);
        }

        public Race GetRace(int id)
        {
            Race? race = _raceRepository.GetById(id);

            if(race == null)
            {
                throw new RaceNotFoundException($"Race with id {id} not found.");
            }
            return race;
        }

        public IEnumerable<Race> GetRaces(int page = 0)
        {
            return _raceRepository.GetRaces(page);
        }

        public void Update(int id, Race race)
        {
            throw new NotImplementedException();
        }

        public long Count(string? name = null)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return _raceRepository.Count();
            }

            string searchTerm = name.Trim().ToLower();
            return _raceRepository.Count((r) =>
                r.Name != null && r.Name.ToLower().Contains(searchTerm)
            );
        }

        public IEnumerable<Race> GetRacesByName(string name)
        {
            return _raceRepository.FindMany(r => r.Name.ToLower().Contains(name));
        }

        public Race GetRaceByName(string name)
        {
            Race? race = _raceRepository.FindOne(r => r.Name == name);
            if (race == null)
            {
                throw new RaceNotFoundException($"Race with id {name} not found.");
            }

            return race;
        }
    }
}
