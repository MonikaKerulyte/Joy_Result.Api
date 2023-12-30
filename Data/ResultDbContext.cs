using Microsoft.EntityFrameworkCore;
using Result.Api.Model.Entity;

namespace Result.Api.Data
{
    public class ResultDbContext : DbContext
    {
        public ResultDbContext(DbContextOptions<ResultDbContext> options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<GameAccount> GameAccounts { get; set; }
        public DbSet<GameResult> GameResults { get; set; }
    }
}
