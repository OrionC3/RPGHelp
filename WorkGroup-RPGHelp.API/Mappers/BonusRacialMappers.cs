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
                BonusName = b.BonusName,
                MalusName = b.MalusName,
                BonusValue = b.BonusValue,
                MalusValue = b.MalusValue,
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
