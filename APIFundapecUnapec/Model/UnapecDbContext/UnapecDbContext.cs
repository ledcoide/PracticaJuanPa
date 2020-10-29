using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIFundapecUnapec.Model.UnapecDbContext
{
    public class UnapecDbContext : DbContext
    {
        public UnapecDbContext(DbContextOptions<UnapecDbContext> options) : base(options)
        {

        }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
