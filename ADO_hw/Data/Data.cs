using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_hw.Data
{
    internal class Data : DbContext
    {
        public DbSet<Entity.Department> Departments { get; set; }
        public DbSet<Entity.Manager> Managers { get; set; }
        public Data() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ado_db;Integrated Security=True"
                );
        }
    }
}
