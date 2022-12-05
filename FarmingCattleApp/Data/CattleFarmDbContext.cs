using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FarmingCattleApp.Models;

namespace FarmingCattleApp.Data
{
    public class CattleFarmDbContext : DbContext
    {
        public CattleFarmDbContext (DbContextOptions<CattleFarmDbContext> options)
            : base(options)
        {
        }

        public DbSet<FarmingCattleApp.Models.CattleModel> CattleModel { get; set; } = default!;
    }
}
