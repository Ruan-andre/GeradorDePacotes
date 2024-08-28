using Microsoft.EntityFrameworkCore;
using GeradorDePacotes.Database.Entities;
namespace GeradorDePacotes.Database
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<ParKey> ParKeys { get; set; }
        public DbSet<FolderToVerify> FoldersToVerify { get; set; }
        public DbSet<FileToVerify> FilesToVerify { get; set; }
        public DbSet<FileToDelete> FilesToDelete { get; set; }
        public DbSet<FolderToDelete> FoldersToDelete { get; set; }
        public DbSet<FileNameOutputLogs> FileNameOutputLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}db.sqlite");
        }
    }
}
