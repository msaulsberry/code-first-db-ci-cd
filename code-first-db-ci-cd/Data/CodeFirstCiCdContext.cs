using code_first_db_ci_cd.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace code_first_db_ci_cd.Data
{
    public class CodeFirstCiCdContext : DbContext
    {

        public CodeFirstCiCdContext(DbContextOptions<CodeFirstCiCdContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
