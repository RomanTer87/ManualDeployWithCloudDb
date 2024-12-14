using Microsoft.EntityFrameworkCore;

namespace ManualDeployWithCloudDb
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Country> Countries {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"
User Id=postgres.mhmyioplvfstphdlizsa;
Password=Ubunta2020!;
Server=aws-0-eu-central-1.pooler.supabase.com;
Port=5432;
Database=postgres
";
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
