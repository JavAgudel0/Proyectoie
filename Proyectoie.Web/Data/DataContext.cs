using Microsoft.EntityFrameworkCore;
using Proyectoie.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyectoie.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<SucursalEntidad> Sucursales { get; set; }
        
        

    }
}
