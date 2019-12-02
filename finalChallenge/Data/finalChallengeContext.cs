using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using finalChallenge.Models;

namespace finalChallenge.Data
{
    public class finalChallengeContext : DbContext
    {
        public finalChallengeContext (DbContextOptions<finalChallengeContext> options)
            : base(options)
        {
        }

        public DbSet<finalChallenge.Models.Fixture> Fixture { get; set; }
    }
}
