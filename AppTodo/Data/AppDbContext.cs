using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace AppTodo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");    
    }
}