using WorkGroup_RPGHelp.API.Models.CharacteresDto;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Mappers
{
    public static class CharactereMappers
    {
        public static CharactereIndexDto ToCharactereIndexDto(this Charactere charactere)
        {
            return new CharactereIndexDto()
            {
                Id = charactere.Id,
                Name = charactere.Name,
                IdRace = charactere.RaceId,
                Level = charactere.Level,
                UserId = charactere.UserId,
                CampagnId = charactere.CampagnId,
                RaceIndexDto = charactere.Race.ToRaceIndexDto(),
            };
        }

        public static CharactereDetailsDto ToCharactereDetailsDto(this Charactere charactere)
        {
            return new CharactereDetailsDto()
            {
                Name = charactere.Name,
                PVMax = charactere.PVMax,
                PVCurrent = charactere.PVCurrent,
                Strength = charactere.Strength,
                Dexterity = charactere.Dexterity,
                Constitution = charactere.Constitution,
                Intelligence = charactere.Intelligence,
                Wisdom = charactere.Wisdom,
                Charisma = charactere.Charisma,
                Defence = charactere.Defence,
                Initiative = charactere.Initiative,
                BaseAttackBonus = charactere.BaseAttackBonus,
                FortitudeSave = charactere.FortitudeSave,
                ReflexeSave = charactere.ReflexeSave,
                WillpowerSave = charactere.WillpowerSave,
                Level = charactere.Level,
                XP = charactere.XP,
                Speed = charactere.Speed,
                RaceId = charactere.RaceId,
                RaceIndexDto = charactere.Race.ToRaceIndexDto(),
            };
        }

        public static Charactere ToCharactere(this CharactereFormDto charactere)
        {
            return new Charactere()
            {
                Name = charactere.Name,
                PVMax = charactere.PVMax,
                PVCurrent = charactere.PVCurrent,
                Strength = charactere.Strength,
                Dexterity = charactere.Dexterity,
                Constitution = charactere.Constitution,
                Intelligence = charactere.Intelligence,
                Wisdom = charactere.Wisdom,
                Charisma = charactere.Charisma,
                Defence = charactere.Defence,
                Initiative = charactere.Initiative,
                BaseAttackBonus = charactere.BaseAttackBonus,
                FortitudeSave = charactere.FortitudeSave,
                ReflexeSave = charactere.ReflexeSave,
                WillpowerSave = charactere.WillpowerSave,
                Level = charactere.Level,
                XP = charactere.XP,
                Speed = charactere.Speed,
                RaceId = charactere.IdRace,
            };
        }
    }
}
