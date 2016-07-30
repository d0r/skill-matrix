using Microsoft.EntityFrameworkCore;
using SkillMatrix.Data.Entity;

namespace SkillMatrix.Data
{
    public class SkillMatrixContext : DbContext
    {
        private string ConnectionString { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<LevelInfo> LevelInfo { get; set; }

        public SkillMatrixContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
