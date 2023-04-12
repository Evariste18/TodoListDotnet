using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.BusinessLogic.Interfaces;
using TodoList.DataAccess;
using TodoList.DataAccess.data;

namespace TodoList.BusinessLogic.Services
{
    public class TacheService : ITache
    {
        private readonly AppDbContext appDbContext;

        public TacheService(AppDbContext dataDbContext)
        {
            appDbContext = dataDbContext;
        }

       
        public IEnumerable<Tache> GetRole()
        {
           return appDbContext.Taches.ToList();
        }

        /*
       public IEnumerable<Tache> GetTacheById(int id)
       {

       }

       public Tache AddTache(Tache tache)
       {

       }

       public Tache UpdateTache(int id)
       {

       }

       public Boolean DeleteTache(int id)
       {

       }
       */
    }
}
