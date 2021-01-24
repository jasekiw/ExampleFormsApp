using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleFormsApp.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>(e =>
            {
                e.HasKey(i => i.Id);
            });
        }
    }
}
