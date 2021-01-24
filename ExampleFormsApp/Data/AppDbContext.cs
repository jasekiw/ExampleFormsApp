using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExampleFormsApp.Data
{
    class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=app.db");
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            Student.OnModelCreating(builder);
        }
    }
}
