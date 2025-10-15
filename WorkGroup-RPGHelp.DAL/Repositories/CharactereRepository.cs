using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.DAL.Repositories.Interfaces;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.DAL.Repositories
{
    public class CharactereRepository : BaseRepository<Charactere>, ICharactereRepository
    {
        public CharactereRepository(DbContext context) : base(context)
        {
        }
    }
}
