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
                throw new Exception($"Name {race.Name} already exist.");
            }
            _raceRepository.Add(race);
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Race GetRace(int id)
        {
            Race? race = _raceRepository.GetById(id);

            if(race == null)
            {
                throw new Exception($"Race with id {id} not found.");
            }
            return race;
        }

        public IEnumerable<Race> GetRaces(int page = 0)
        {
            return _raceRepository.GetRaces();
        }

        public void Update(int id, Race race)
        {
            throw new NotImplementedException();
        }
    }
}
