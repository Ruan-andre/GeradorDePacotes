using GeradorDePacotes.Classes;
using GeradorDePacotes.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace GeradorDePacotes.Database
{
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    public static class UtilDb
    {
        #region["GenericFields AddOrUpdate"]

        public static async Task AddOrUpdateFileName(ApplicationDbContext ctx, string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentNullException("O nome do arquivo não pode ser vazio");

            var fileNameLog = ctx.FileNameOutputLogs
                    .AsEnumerable()
                    .FirstOrDefault(x => x.NameFile.Equals(fileName));

            var lastSelected = await ctx.FileNameOutputLogs.Where(x => x.LastSelected == true).FirstOrDefaultAsync();

            if (fileNameLog != null)
            {
                fileNameLog.LastSelected = true;
            }
            else
            {
                var newFileNameOutput = new FileNameOutputLogs
                {
                    NameFile = fileName
                };
            }

            if (lastSelected != null)
                lastSelected.LastSelected = false;

            await ctx.SaveChangesAsync().ConfigureAwait(false);
        }
     
        #endregion

        #region["DataGrids AddOrUpdate"]

        public async static Task AddOrUpdateToGridFoldersToDeleteAsync(ApplicationDbContext ctx, string pathFolder, string pathTargetFolder, bool disconsider = false)
        {
            var nameFolder = Helpers.GetNameWithoutPathForTargetFolder(pathFolder, Frm_ConfigUC.PathTargetFolder);

            var folderInDb = await ctx.FoldersToDelete
                .AsQueryable()
                .FirstOrDefaultAsync(f => f.NameFolder.ToLower() == nameFolder.ToLower());

            if (folderInDb != null)
            {
                folderInDb.NameFolder = nameFolder;
            }
            else
            {
                var folder = new FoldersToDelete
                {
                    NameFolder = nameFolder,
                    Disconsider = disconsider
                };

                ctx.Add(folder);
            }
            await ctx.SaveChangesAsync();
        }

        public async static Task AddOrUpdateToGridFilesToDeleteAsync(ApplicationDbContext ctx, string[] paths, bool disconsider = false)
        {
            foreach (var path in paths)
            {
                var nameFile = Helpers.GetNameWithoutPathForTargetFolder(path, Frm_ConfigUC.PathTargetFolder);
                var fileInDb = await ctx.FilesToDelete
                    .AsQueryable()
                    .FirstOrDefaultAsync(f => f.NameFile.ToLower() == nameFile.ToLower());

                if (fileInDb != null)
                {
                    fileInDb.NameFile = nameFile;
                }
                else
                {
                    var folder = new FilesToDelete
                    {
                        NameFile = nameFile,
                        Disconsider = disconsider
                    };

                    ctx.Add(folder);
                }
                await ctx.SaveChangesAsync();
            }
        }


        public async static Task AddOrUpdateToGridFoldersToVerifyAsync(ApplicationDbContext ctx, string pathFolder, bool disconsider = false)
        {
            var nameFolder = Helpers.GetNameWithoutPathForTargetFolder(pathFolder, Frm_ConfigUC.PathTargetFolder);

            var folderInDb = await ctx.FoldersToVerify
                .AsQueryable()
                .FirstOrDefaultAsync(f => f.NameFolder.ToLower() == nameFolder.ToLower());

            if (folderInDb != null)
            {
                folderInDb.NameFolder = nameFolder;
            }
            else
            {
                var folder = new FoldersToVerify
                {
                    NameFolder = nameFolder,
                    Disconsider = disconsider
                };

                ctx.Add(folder);
            }
            await ctx.SaveChangesAsync();
        }

        public async static Task AddOrUpdateToGridFilesToVerifyAsync(ApplicationDbContext ctx, string[] names, bool disconsider = false)
        {
            foreach (var name in names)
            {
                var pathFile = Helpers.GetNameWithoutPathForTargetFolder(name, Frm_ConfigUC.PathTargetFolder);
                var fileInDb = await ctx.FilesToVerify
                    .AsQueryable()
                    .FirstOrDefaultAsync(f => f.NameFile.ToLower() == pathFile.ToLower());

                if (fileInDb != null)
                {
                    fileInDb.NameFile = pathFile;
                }
                else
                {
                    var file = new FilesToVerify
                    {
                        NameFile = pathFile,
                        Disconsider = disconsider
                    };

                    ctx.Add(file);
                }
                await ctx.SaveChangesAsync();
            }
        }

        #endregion

        #region["Tables AddOrUpdate"]

        public async static Task AddOrUpdateTableFoldersToDeleteAsync(ApplicationDbContext ctx, string? name = null, int? id = null, bool? disconsider = null)
        {
            if (string.IsNullOrWhiteSpace(name) && id == null)
                throw new ArgumentException("O nome e o ID não podem ser nulos nesse método");

            var fileInDb = await ctx.FoldersToDelete
                .AsQueryable()
                .FirstOrDefaultAsync(f => id == null || f.Id == id);

            if (fileInDb != null)
            {
                fileInDb.NameFolder = string.IsNullOrWhiteSpace(name) ? fileInDb.NameFolder : name;
                fileInDb.Disconsider = disconsider ?? fileInDb.Disconsider;
            }
            else
            {
                var folder = new FoldersToDelete
                {
                    NameFolder = string.IsNullOrWhiteSpace(name) ? "Erro!" : name,
                    Disconsider = disconsider ?? false
                };
                ctx.Add(folder);
            }
            await ctx.SaveChangesAsync(); // SaveChangesAsync não bloqueia a UI
        }

        public async static Task AddOrUpdateTableFilesToDeleteAsync(ApplicationDbContext ctx, string? name = null, int? id = null, bool? disconsider = null)
        {
            if (string.IsNullOrWhiteSpace(name) && id == null)
                throw new ArgumentException("O nome e o ID não podem ser nulos nesse método");

            var fileInDb = await ctx.FilesToDelete
                .AsQueryable()
                .FirstOrDefaultAsync(f => id == null || f.Id == id);

            if (fileInDb != null)
            {
                fileInDb.NameFile = !string.IsNullOrWhiteSpace(name) ? name : fileInDb.NameFile;
                fileInDb.Disconsider = disconsider ?? fileInDb.Disconsider;
            }
            else
            {
                var file = new FilesToDelete
                {
                    NameFile = !string.IsNullOrWhiteSpace(name) ? name : "Erro!",
                    Disconsider = disconsider ?? false
                };

                ctx.Add(file);
            }
            await ctx.SaveChangesAsync();
        }

        public async static Task AddOrUpdateTableFoldersToVerifyAsync(ApplicationDbContext ctx, string? name = null, int? id = null, bool? disconsider = null)
        {
            if (string.IsNullOrWhiteSpace(name) && id == null)
                throw new ArgumentException("O nome e o ID não podem ser nulos nesse método");

            var fileInDb = await ctx.FoldersToVerify
                .AsQueryable()
                .FirstOrDefaultAsync(f => id == null || f.Id == id);

            if (fileInDb != null)
            {
                fileInDb.NameFolder = string.IsNullOrWhiteSpace(name) ? fileInDb.NameFolder : name;
                fileInDb.Disconsider = disconsider ?? fileInDb.Disconsider;
            }
            else
            {
                var folder = new FoldersToVerify
                {
                    NameFolder = string.IsNullOrWhiteSpace(name) ? "Erro!" : name,
                    Disconsider = disconsider ?? false
                };

                ctx.Add(folder);
            }
            await ctx.SaveChangesAsync();
        }

        public async static Task AddOrUpdateTableFilesToVerifyAsync(ApplicationDbContext ctx, string? name = null, int? id = null, bool? disconsider = null)
        {
            if (string.IsNullOrWhiteSpace(name) && id == null)
                throw new ArgumentException("O nome e o ID não podem ser nulos nesse método");

            var fileInDb = await ctx.FilesToVerify
                .AsQueryable()
                .FirstOrDefaultAsync(f => id == null || f.Id == id);

            if (fileInDb != null)
            {
                fileInDb.NameFile = string.IsNullOrWhiteSpace(name) ? fileInDb.NameFile : name;
                fileInDb.Disconsider = disconsider ?? fileInDb.Disconsider;
            }
            else
            {
                var file = new FilesToVerify
                {
                    NameFile = string.IsNullOrWhiteSpace(name) ? "Erro!" : name,
                    Disconsider = disconsider ?? false
                };

                ctx.Add(file);
            }
            await ctx.SaveChangesAsync();
        }
      
        public async static Task AddOrUpdateTableParKeysAsync(ApplicationDbContext ctx, string parName, string parValue)
        {
            var par = await ctx.ParKeys
                .AsQueryable()
                .FirstOrDefaultAsync(x => x.ParName.Equals(parName));

            if (par != null)
            {
                par.ParValue = parValue;
            }
            else
            {
                var newParKey = new ParKey
                {
                    ParName = parName,
                    ParValue = parValue
                };

                ctx.ParKeys.Add(newParKey);
            }
            await ctx.SaveChangesAsync();
        }

       
       
        #endregion

        #region["Selects"]
        public static async Task<string?> GetLastSelectedFileNameAsync(ApplicationDbContext ctx)
        {
            return await ctx.FileNameOutputLogs
                                     .Where(x => x.LastSelected == true)
                                     .Select(x => x.NameFile)
                                     .FirstOrDefaultAsync();
        }

        public static async Task<string[]> GetListFileName(ApplicationDbContext ctx)
        {
            return await ctx.FileNameOutputLogs.Select(x => x.NameFile).ToArrayAsync();
        }
        public async static Task<string?> GetParValueAsync(ApplicationDbContext ctx, string parName)
        {
            return await ctx.ParKeys
                .AsQueryable()
                .Where(x => x.ParName.Equals(parName))
                .Select(x => x.ParValue)
                .FirstOrDefaultAsync();
        }

        #endregion

        #region["Deletes"]
        public async static Task ClearTableAsync(ApplicationDbContext ctx, string tableName)
        {
            if (string.IsNullOrWhiteSpace(tableName))
                throw new ArgumentException("Nome da tabela não pode ser nulo ou vazio.", nameof(tableName));

            var sqlDelete = $"DELETE FROM {tableName}";
            await ctx.Database.ExecuteSqlRawAsync(sqlDelete);
        }
        public async static Task DeleteAsync<T>(ApplicationDbContext ctx, string tableName, object id) where T : class
        {
            var dbSet = ctx.Set<T>();

            var entity = await dbSet.FindAsync(id);

            if (entity == null)
            {
                throw new Exception("Registro não encontrado.");
            }

            dbSet.Remove(entity);
            await ctx.SaveChangesAsync();
        }


        #endregion


    }
}
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
