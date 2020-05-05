using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Mendela_Alexandru_Abel_Rp.Models;

namespace Asp_Mendela_Alexandru_Abel_Rp.Data
{
    public class Asp_Mendela_Alexandru_Abel_RpContext : DbContext
    {
        public Asp_Mendela_Alexandru_Abel_RpContext (DbContextOptions<Asp_Mendela_Alexandru_Abel_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Mendela_Alexandru_Abel_Rp.Models.Movie> Movie { get; set; }
    }
}
