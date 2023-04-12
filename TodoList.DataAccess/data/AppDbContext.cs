using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
                Dbcontextoptions.UseSqlServer("Server=DESKTOP-S5CH96I;Database=TacheManagement;User Id=sa;Password=1234;Encrypt=False");
                //Dbcontextoptions.UseSqlServer("Server=127.0.0.1;Database=UnivAssurance;Trusted_Connection=True;"); //Chaine de connexion
            }
        }
    }
}
