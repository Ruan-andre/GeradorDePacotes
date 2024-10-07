using Microsoft.EntityFrameworkCore;
using GeradorDePacotes.Database.Entities;
namespace GeradorDePacotes.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ParKey> ParKeys { get; set; }
        public DbSet<FoldersToVerify> FoldersToVerify { get; set; }
        public DbSet<FilesToVerify> FilesToVerify { get; set; }
        public DbSet<FilesToDelete> FilesToDelete { get; set; }
        public DbSet<FoldersToDelete> FoldersToDelete { get; set; }
        public DbSet<FileNameOutputLogs> FileNameOutputLogs { get; set; }
        public DbSet<DeletedFolders> DeletedFolders { get; set; }
        public DbSet<DeletedFiles> DeletedFiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}db.sqlite");
        }
    }
}
