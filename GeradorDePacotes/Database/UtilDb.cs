using GeradorDePacotes.Classes;
using GeradorDePacotes.Database.Entities;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDePacotes.Database
{
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    public class UtilDb
    {
        #region["DataGrids"]

        public static void AddOrUpdateToGridFoldersToDelete(ApplicationDbContext ctx, string pathFolder, string pathTargetFolder, bool disconsider = false)
        {
            var nameFolder = Helpers.GetNameWithoutPathForTargetFolder(pathFolder, Frm_ConfigUC.PathTargetFolder);

            var folderInDb = ctx.FoldersToDelete
                .AsEnumerable()
                .FirstOrDefault(f => f.NameFolder.Equals(nameFolder, StringComparison.OrdinalIgnoreCase));

            if (folderInDb != null)
            {
                folderInDb.NameFolder = nameFolder;
                ctx.SaveChanges();

            }
            else
            {
                var folder = new FoldersToDelete
                {
                    NameFolder = nameFolder,
                    Disconsider = disconsider
                };

                ctx.Add(folder);
                ctx.SaveChanges();
            }
        }

        public static void AddOrUpdateToGridFilesToDelete(ApplicationDbContext ctx, string[] paths, bool disconsider = false)
        {
            foreach (var path in paths)
            {
               var nameFile =  Helpers.GetNameWithoutPathForTargetFolder(path, Frm_ConfigUC.PathTargetFolder);
                var fileInDb = ctx.FilesToDelete
                    .AsEnumerable()
                    .FirstOrDefault(f => f.NameFile.Equals(nameFile, StringComparison.OrdinalIgnoreCase));

                if (fileInDb != null)
                {
                    fileInDb.NameFile = nameFile;
                    ctx.SaveChanges();
                }
                else
                {
                    var folder = new FilesToDelete
                    {
                        NameFile = nameFile,
                        Disconsider = disconsider
                    };

                    ctx.Add(folder);
                    ctx.SaveChanges();
                }
            }
        }

        public static void AddOrUpdateToGridFoldersToVerify(ApplicationDbContext ctx, string pathFolder, bool disconsider = false)
        {
            var nameFolder = Helpers.GetNameWithoutPath(pathFolder);

            var folderInDb = ctx.FoldersToVerify
                .AsEnumerable()
                .FirstOrDefault(f => f.NameFolder.Equals(nameFolder, StringComparison.OrdinalIgnoreCase));

            if (folderInDb != null)
            {
                folderInDb.NameFolder = nameFolder;
                ctx.SaveChanges();
            }
            else
            {
                var folder = new FoldersToVerify
                {
                    NameFolder = nameFolder,
                    Disconsider = disconsider
                };

                ctx.Add(folder);
                ctx.SaveChanges();
            }
        }

        public static void AddOrUpdateToGridFilesToVerify(ApplicationDbContext ctx, string[] names, bool disconsider = false)
        {
            foreach (var name in names)
            {
                var fileInDb = ctx.FilesToDelete
                    .AsEnumerable()
                    .FirstOrDefault(f => f.NameFile.Equals(name, StringComparison.OrdinalIgnoreCase));

                if (fileInDb != null)
                {
                    fileInDb.NameFile = name;
                    ctx.SaveChanges();
                }
                else
                {
                    var folder = new FilesToDelete
                    {
                        NameFile = name,
                        Disconsider = disconsider
                    };

                    ctx.Add(folder);
                    ctx.SaveChanges();
                }
            }
        }

        #endregion

        #region["Tables"]

        public static void AddOrUpdateTableFoldersToDelete(ApplicationDbContext ctx, string? name = null, int? id = null, bool? disconsider = null)
        {
            if (string.IsNullOrWhiteSpace(name) && id == null)
                throw new Exception("O nome e o ID não podem ser nulos nesse método");

            var fileInDb = ctx.FoldersToDelete
                .AsEnumerable()
                .FirstOrDefault(f => (string.IsNullOrWhiteSpace(name) || f.NameFolder.Equals(name, StringComparison.OrdinalIgnoreCase))
                                     && (id == null || f.Id == id));

            if (fileInDb != null)
            {
                fileInDb.NameFolder = string.IsNullOrWhiteSpace(name) ? fileInDb.NameFolder : name ;
                fileInDb.Disconsider = disconsider == null ? fileInDb.Disconsider : (bool)disconsider;
            }
            else
            {
                var folder = new FoldersToDelete
                {
                    NameFolder = string.IsNullOrWhiteSpace(name) ? "Erro!" : name,
                    Disconsider = disconsider == null ? false : (bool)disconsider
                };
                ctx.Add(folder);
            }
                ctx.SaveChanges();
        }

        public static void AddOrUpdateTableFilesToDelete(ApplicationDbContext ctx, string? name = null, int? id = null, bool? disconsider = null)
        {
            if (string.IsNullOrWhiteSpace(name) && id == null)
                throw new Exception("O nome e o ID não podem ser nulos nesse método");

            var fileInDb = ctx.FilesToDelete
                .AsEnumerable()
                .FirstOrDefault(f => (string.IsNullOrWhiteSpace(name) || f.NameFile.Equals(name, StringComparison.OrdinalIgnoreCase))
                                     && (id == null || f.Id == id));

            if (fileInDb != null)
            {
                fileInDb.NameFile = !string.IsNullOrWhiteSpace(name) ? name : fileInDb.NameFile;
                fileInDb.Disconsider = disconsider == null ? fileInDb.Disconsider : (bool)disconsider;
                ctx.SaveChanges();

            }
            else
            {
                var file = new FilesToDelete
                {
                    NameFile = !string.IsNullOrWhiteSpace(name) ? name : "Erro!",
                    Disconsider = disconsider == null ? false : (bool)disconsider
                };

                ctx.Add(file);
                ctx.SaveChanges();
            }
        }

        public static void AddOrUpdateTableFoldersToVerify(ApplicationDbContext ctx, string? name = null, int? id = null, bool? disconsider = null)
        {
            if (string.IsNullOrWhiteSpace(name) && id == null)
                throw new Exception("O nome e o ID não podem ser nulos nesse método");

            var fileInDb = ctx.FoldersToVerify
                .AsEnumerable()
                .FirstOrDefault(f => (string.IsNullOrWhiteSpace(name) || f.NameFolder.Equals(name, StringComparison.OrdinalIgnoreCase))
                                     && (id == null || f.Id == id));

            if (fileInDb != null)
            {
                fileInDb.NameFolder = name;
                fileInDb.Disconsider = disconsider == null ? false : (bool)disconsider;
                ctx.SaveChanges();

            }
            else
            {
                var folder = new FoldersToVerify
                {
                    NameFolder = name,
                    Disconsider = disconsider == null ? false : (bool)disconsider
                };

                ctx.Add(folder);
                ctx.SaveChanges();
            }
        }

        public static void AddOrUpdateTableFilesToVerify(ApplicationDbContext ctx, string? name = null, int? id = null, bool? disconsider = null)
        {
            if (string.IsNullOrWhiteSpace(name) && id == null)
                throw new Exception("O nome e o ID não podem ser nulos nesse método");

            var fileInDb = ctx.FilesToVerify
                .AsEnumerable()
                .FirstOrDefault(f => (string.IsNullOrWhiteSpace(name) || f.NameFile.Equals(name, StringComparison.OrdinalIgnoreCase))
                                     && (id == null || f.Id == id));

            if (fileInDb != null)
            {
                fileInDb.NameFile = name;
                ctx.SaveChanges();

            }
            else
            {
                var file = new FilesToVerify
                {
                    NameFile = name,
                    Disconsider = disconsider == null ? false : (bool)disconsider
                };

                ctx.Add(file);
                ctx.SaveChanges();
            }
        }

        public async static Task DeleteAsync<T>(ApplicationDbContext ctx, string tableName, object id) where T : class
        {
            var dbSet = ctx.Set<T>();

            var entity = await dbSet.FindAsync(id);

            if (entity == null)
            {
                throw new Exception("Registro não encontrado.");
            }

            // Remove a entidade
            dbSet.Remove(entity);

            // Salva as alterações
            await ctx.SaveChangesAsync();
        }

        public static void AddOrUpdateTableParKeys(ApplicationDbContext ctx, string parName, string parValue)
        {
            var par = ctx.ParKeys
                .Where(x => x.ParName.Equals(parName))
                .FirstOrDefault();

            if (par != null)
            {
                par.ParValue = parValue;
                ctx.SaveChanges();
            }
            else
            {
                var newParKey = new ParKey
                {
                    ParName = parName,
                    ParValue = parValue
                };

                ctx.ParKeys.Add(newParKey);
                ctx.SaveChanges();
            }
        }

        public static string GetParValue(ApplicationDbContext ctx, string parName)
        {
            return ctx.ParKeys.Where(x => x.ParName.Equals(parName)).Select(x => x.ParValue).FirstOrDefault()!;
        }

        #endregion
    }
}
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
