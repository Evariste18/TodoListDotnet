using System.Transactions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.BusinessLogic.Interfaces;
using TodoList.DataAccess.Models;
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

       
        public IEnumerable<Tache> GetTache(int page, int pageSize)
        {
            IEnumerable<Tache> taches = appDbContext.Taches.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            if(taches!=null) return taches;

            return null;
        }

       
       public Tache GetTacheById(int id)
       {
            Tache? tache = appDbContext.Taches.Where(t => t.Id == id).SingleOrDefault();

            if(tache!=null) return tache;

            return null;
            
       }

       public Tache AddTache(Tache task)
       {
            Tache tache = new Tache();
            tache.Titre = task.Titre;
            tache.Description = task.Description;
            tache.statut = task.statut;

            appDbContext.Add<Tache>(tache);
            appDbContext.SaveChanges();

            return tache;

       }
      
       public Tache UpdateTache(Tache task)
       {
            Tache tache = GetTacheById(task.Id);

            if(tache != null)
            {
                tache.Titre = task.Titre;
                tache.Description = task.Description;
                tache.statut = task.statut;
                appDbContext.Update(tache);
                appDbContext.SaveChanges();

                return tache;
            }

            return null;
            
       }

       public Boolean DeleteTache(int id)
       {
            Tache tache = GetTacheById(id);
            if(tache != null)
            {
                appDbContext.Remove(tache);
                appDbContext.SaveChanges();
                return true;
            }

            return false;
       }
      
    }
}
