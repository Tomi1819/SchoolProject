using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data.Models
{
    public class Context :DbContext
    {
        DbSet<Course> Classes { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-3E8OOLTV\\MSSQLSERVER02;database=SchoolDB;trusted_connection=true;");
        }
    }
}
