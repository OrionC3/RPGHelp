using System.Runtime.CompilerServices;
using WorkGroup_RPGHelp.API.Models.RaceDto;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Mappers
{
    public static class RaceMappers
    {
        public static RaceIndexDto ToRaceIndexDto(this Race r)
        {
            return new RaceIndexDto()
            {
                Id = r.Id,
                Name = r.Name,
                TravelSpeed = r.TravelSpeed,
                BonusRacial = r.BonusRacial?.ToBonusRacialDto(),
            };
        }

        public static BonusRacialIndexDto ToBonusRacialDto(this BonusRacial b)
        {
            if(b == null)
            {
                return null;
            }

            return new BonusRacialIndexDto
            {
                Id = b.Id,
                BonusName = b.BonusName,
                BonusValue = b.BonusValue,
                MalusName = b.MalusName,
                MalusValue = b.MalusValue,
            };
        }

        public static Race ToRace(this RaceFormDto r)
        {
            return new Race()
            {
                Name = r.Name,
                TravelSpeed = r.TravelSpeed,
                BonusRacial = r.BonusRacialFormDto.ToBonusRacial(),
            };
        }
    }
}
