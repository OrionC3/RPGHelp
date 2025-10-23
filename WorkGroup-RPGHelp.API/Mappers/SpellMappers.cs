using System.Runtime.CompilerServices;
using WorkGroup_RPGHelp.API.Models.SpellsDto;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Mappers
{
    public static class SpellMappers
    {
        public static SpellIndexDto ToSpellIndexDto(this Spell s)
        {
            return new SpellIndexDto()
            {
                Id = s.Id,
                Name = s.Name,
                Level = s.Level,
                Description = s.Description,
            };
        }

        public static Spell ToSpell(this SpellFormDto s)
        {
            return new Spell()
            {
                Name = s.Name,
                Level = s.Level,
                Description = s.Description,
            };
        }
    }
}
