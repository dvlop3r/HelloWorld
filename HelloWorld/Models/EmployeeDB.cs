using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HelloWorld.Models
{
    public class EmployeeDB : DbContext
    {
        public DbSet<Employees> Employees{ get; set; }

        public EmployeeDB(DbContextOptions<EmployeeDB> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
