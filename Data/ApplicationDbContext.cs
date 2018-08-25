
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }
}