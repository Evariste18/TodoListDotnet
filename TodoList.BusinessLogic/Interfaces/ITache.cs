using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.DataAccess.Models;

namespace TodoList.BusinessLogic.Interfaces
{
    public interface ITache
    {
        IEnumerable<Tache> GetTache(int page, int pageSize);
        Tache GetTacheById(int id);
        Tache AddTache(Tache task);
        Tache UpdateTache(Tache task);
        Boolean DeleteTache(int id);
        
    }
}
