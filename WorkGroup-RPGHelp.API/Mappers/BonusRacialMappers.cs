using System.Runtime.CompilerServices;
using WorkGroup_RPGHelp.API.Models.RaceDto;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Mappers
{
    public static class BonusRacialMappers 
    {
        public static BonusRacialIndexDto ToBonusRacialIndexDto(this BonusRacial b)
        {
            return new BonusRacialIndexDto()
            {
                Name = b.Name,
                Name2 = b.Name2,
                Bonus = b.Bonus,
                Malus = b.Malus,
            };
        }

        public static BonusRacial ToBonusRacial(this BonusRacialFormDto b)
        {
            return new BonusRacial()
            {
                Name = b.Name,
                Name2 = b.Name2,
                Bonus = b.Bonus,
                Malus = b.Malus,
            };
        }
    }
}
