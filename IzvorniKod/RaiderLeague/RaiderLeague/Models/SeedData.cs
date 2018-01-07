using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RaiderLeague.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RaiderLeague.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RaiderLeagueContext(
                serviceProvider.GetRequiredService<DbContextOptions<RaiderLeagueContext>>()))
            {
                if (context.Operation.Any())
                {
                    return;   // DB has been seeded.
                }

                Boss b1, b2, b3, b4, b5;

                context.Boss.AddRange(
                     b1 = new Boss { BossName = "Boss1", Damage = 100, Health = 25, Difficulty = Difficulty.LAGANO },
                     b2 = new Boss { BossName = "Boss2", Damage = 100, Health = 25, Difficulty = Difficulty.LAGANO },
                     b3 = new Boss { BossName = "Boss3", Damage = 100, Health = 25, Difficulty = Difficulty.LAGANO },
                     b4 = new Boss { BossName = "Boss4", Damage = 100, Health = 25, Difficulty = Difficulty.LAGANO },
                     b5 = new Boss { BossName = "Boss5", Damage = 100, Health = 25, Difficulty = Difficulty.LAGANO }
                );
                List<Boss> lista = new List<Boss> { b1, b2, b3, b4, b5 };
                context.Operation.AddRange(
                     new Operation { OperationName = "Operacija1", difficulty = Difficulty.LAGANO, bosses = lista }
                );
                context.Boss.AddRange(
                     b1 = new Boss { BossName = "Boss6", Damage = 100, Health = 25, Difficulty = Difficulty.TESKO },
                     b2 = new Boss { BossName = "Boss7", Damage = 100, Health = 25, Difficulty = Difficulty.TESKO },
                     b3 = new Boss { BossName = "Boss8", Damage = 100, Health = 25, Difficulty = Difficulty.TESKO },
                     b4 = new Boss { BossName = "Boss9", Damage = 100, Health = 25, Difficulty = Difficulty.TESKO },
                     b5 = new Boss { BossName = "Boss10", Damage = 100, Health = 25, Difficulty = Difficulty.UMJERENO }
                );
                lista = new List<Boss> { b1, b2, b3, b4, b5 };
                context.Operation.AddRange(
                     new Operation { OperationName = "Operacija1", difficulty = Difficulty.TESKO, bosses = lista }
                );
                context.SaveChanges();

            }
        }
    }
}