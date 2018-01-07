using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RaiderLeague.Models;

namespace RaiderLeague.Models
{
    public class RaiderLeagueContext : DbContext
    {
        public RaiderLeagueContext (DbContextOptions<RaiderLeagueContext> options)
            : base(options)
        {
        }

        public DbSet<RaiderLeague.Models.RegisteredUser> RegisteredUser { get; set; }

        public DbSet<RaiderLeague.Models.Operation> Operation { get; set; }

        public DbSet<RaiderLeague.Models.BattleLog> BattleLog { get; set; }

        public DbSet<RaiderLeague.Models.Boss> Boss { get; set; }

        public DbSet<RaiderLeague.Models.ErrorViewModel> ErrorViewModel { get; set; }

        public DbSet<RaiderLeague.Models.Result> Result { get; set; }

    }
}
