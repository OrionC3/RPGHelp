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
                IdRace = charactere.IdRace,
                Level = charactere.Level,
                UserId = charactere.UserId,
                Users = charactere.Users,
                CampagnId = charactere.CampagnId,
                Campagns = charactere.Campagns,
            };
        }

        public static CharactereDetailsDto ToCharactereDetailsDto(this Charactere charactere)
        {
            return new CharactereDetailsDto()
            {
                Name = charactere.Name,
                IdRace = charactere.IdRace,
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
            };
        }

        public static Charactere ToCharactere(this CharactereFormDto charactere)
        {
            return new Charactere()
            {
                Id = charactere.Id,
                Name = charactere.Name,
                IdRace = charactere.IdRace,
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
                CampagnId = charactere.CampagnId,
                UserId = charactere.UserId,
            };
        }
    }
}
