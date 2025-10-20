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
                Name = b.BonusName,
                Name2 = b.MalusName,
                Bonus = b.BonusValue,
                Malus = b.MalusValue,
            };
        }

        public static BonusRacial ToBonusRacial(this BonusRacialFormDto b)
        {
            return new BonusRacial()
            {
                BonusName = b.BonusName,
                MalusName = b.MalusName,
                BonusValue = b.BonusValue,
                MalusValue = b.MalusValue,
            };
        }
    }
}
