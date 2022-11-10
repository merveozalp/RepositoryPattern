using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Data.Concrete.EntityFramework.Context
{
    public class MyContext:DbContext
    {
        public MyContext()
        {

        }
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                ("Server=DESKTOP-301760G\\SQLEXPRESS;Database=CourseDb;Trusted_Connection = True");
        }

    }
}
