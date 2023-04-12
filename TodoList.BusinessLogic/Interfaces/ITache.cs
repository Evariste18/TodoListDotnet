using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.DataAccess;

namespace TodoList.BusinessLogic.Interfaces
{
    public interface ITache
    {
        public IEnumerable<Tache> GetRole();
        //public IEnumerable<Tache> GetTacheById(int id);
        //public Tache AddTache(Tache tache);
        //public Tache UpdateTache(int id);
        //public Boolean DeleteTache(int id);
    }
}
