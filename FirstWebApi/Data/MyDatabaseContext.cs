using FirstWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApi.Data
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Animals> Animals { get; set; }
        public DbSet<AnimalTypes> AnimalTypes { get; set; }
        public DbSet<Owners> Owners { get; set; }
    }   
}
