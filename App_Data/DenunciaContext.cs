using DenunciaAPI.App_Code;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenunciaAPI.App_Data
{
    public class DenunciaContext: DbContext
    {
        public DenunciaContext(DbContextOptions<DenunciaContext> options):base(options)
        {

        }

        public DbSet<Denuncia> DenunciaItems { get; set; }
    }
}
