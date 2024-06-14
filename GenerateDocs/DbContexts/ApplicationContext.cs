using GenerateDocs.Models.Disciplines;
using GenerateDocs.Models.EducationProgramms;
using GenerateDocs.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace GenerateDocs.DbContexts
{
    public class ApplicationContext: DbContext
    {
        public DbSet<User> Users { get; set; } = null;
        public DbSet<EducationProgramm> EducationProgramms { get; set; } = null;
        public DbSet<Discipline> Disciplines { get; set; } = null;
        public DbSet<CompetenceInfo> CompetenceInfos { get; set; } = null;
        public DbSet<DisciplineInfo> DisciplineInfos { get; set; } = null;
        public DbSet<LaborIntensity> LaborIntensities { get; set; } = null;


        public ApplicationContext()
        {
            // Database.EnsureCreated();
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=GenerateDocuments;Username=postgres;Password=admin");
        }
    }
}
