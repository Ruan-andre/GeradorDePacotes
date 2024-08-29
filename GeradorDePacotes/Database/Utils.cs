using GeradorDePacotes.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDePacotes.Database
{
    public class Utils
    {
        public static void AddOrUpdateParKeys(ApplicationDbContext ctx, string parName, string parValue)
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
            return ctx.ParKeys.Where(x=>x.ParName.Equals(parName)).Select(x=>x.ParValue).FirstOrDefault();
        }
    }
}
