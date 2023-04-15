using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoList.DataAccess.Models;

namespace TodoList.DataAccess.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<DbContext> options) : base(options)
        {

        }

        public virtual DbSet<Tache> Taches { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder Dbcontextoptions)
        {
            if (!Dbcontextoptions.IsConfigured)
            {
                Dbcontextoptions.UseSqlServer("Server=DESKTOP-TABS97I;Database=TacheManagement;User Id=sa;Password=1234;Encrypt=False");
            }
        }
    }
}
