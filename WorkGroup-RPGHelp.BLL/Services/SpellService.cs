using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.BLL.Exceptions.Spells;
using WorkGroup_RPGHelp.BLL.Services.Interfaces;
using WorkGroup_RPGHelp.DAL.Repositories.Interfaces;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.BLL.Services
{
    public class SpellService : ISpellService
    {
        private readonly ISpellRepository _spellRepository;

        public SpellService(ISpellRepository spellRepository)
        {
            _spellRepository = spellRepository;
        }

        public void Add(Spell spell)
        {
            if(_spellRepository.FindOne(s => s.Name == spell.Name) != null)
            {
                throw new SpellAlreadyExistException($"Spell {spell.Name} already exist");
            }
            _spellRepository.Add(spell);
        }

        public void Delete(int id)
        {
            Spell? spell = _spellRepository.FindOne(id);
            if(spell == null)
            {
                throw new SpellNotFoundException($"Spell with {id} doesn't exist");
            }
            _spellRepository.Delete(spell);
        }

        public Spell GetSpell(int id)
        {
            Spell? spell = _spellRepository.FindOne(id);

            if(spell == null)
            {
                throw new SpellNotFoundException($"Spell with id {id} not found");
            }
            return spell;
        }

        public IEnumerable<Spell> GetSpells(int page = 0)
        {
            return _spellRepository.GetSpells();
        }

        public void Update(int id, Spell spell)
        {
            Spell? s = _spellRepository.FindOne(s => s.Id == id);

            if(s == null)
            {
                throw new SpellNotFoundException($"Spell with {id} not found");
            }
            
            if(spell.Id > 0)
            {
                s.Id = spell.Id;
            }
            s.Name = spell.Name;

            if (spell.Name != null)
            {
                s.Name = spell.Name;
            }
            s.Level = spell.Level;

            if(spell.Description != null)
            {
                s.Description = spell.Description;
            }
            _spellRepository.Update(s);
        }
    }
}
