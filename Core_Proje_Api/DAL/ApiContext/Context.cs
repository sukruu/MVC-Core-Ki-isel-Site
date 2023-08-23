using Core_Proje_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje_Api.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-15B3EEU;Database=CoreProjeDB2;integrated security= true;Encrypt=False");
        }

        public DbSet<Category> Categories { get; set; }
    }
}

