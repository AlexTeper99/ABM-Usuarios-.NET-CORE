using CrudNetCore5.Models; // traigo los modelos
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

             
        }

        //por fuera instancio los modelos

        public DbSet<Usuario> Usuario { get; set; }
    }
}
