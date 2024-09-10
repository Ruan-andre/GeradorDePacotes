

using GeradorDePacotes.Database;
using Microsoft.EntityFrameworkCore;
using System.IO.Packaging;

namespace GeradorDePacotes.Classes
{
    internal class Package
    {
        public string? FileName { get; set; }
        public string? TargetFolder { get; set; }
        public string? OutputFolder { get; set; }
        private ApplicationDbContext _context { get; set; }

        public Package(ApplicationDbContext ctx)
        {
            _context = ctx;
            FillOwnFields();
        }
        public static void GeneratePackage()
        {
        }

        private async void FillOwnFields()
        {
            var name = await UtilDb.GetLastSelectedFileNameAsync(_context);
            var parValue = await UtilDb.GetParValueAsync(_context, "add_date_and_time_to_name");
            var addDateAndTime = !string.IsNullOrWhiteSpace(parValue) ? Convert.ToBoolean(parValue) : false;
            var date = addDateAndTime ? DateTime.Now.ToString("yyyyMMddHHmm") : string.Empty;

            if (!string.IsNullOrWhiteSpace(name))
                FileName = name + date;
            else
                FileName = "Package" + DateTime.Now.ToString("yyyyMMddHHmm");

            var directory = await UtilDb.GetParValueAsync(_context, "target_folder");

            if (!string.IsNullOrWhiteSpace(directory))
                TargetFolder = directory;
            else 
                TargetFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "packages");
        }
    }
}
