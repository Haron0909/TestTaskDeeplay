using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskDeeplayWpf.DbModels
{
    class DbTestContext:DbContext
    {
        public DbSet<Staff> staff { get; set; } = null!;
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=116238;database=testtaskdeeplay;",
                new MySqlServerVersion(new Version(8, 0, 26)));
        }
    }
}
