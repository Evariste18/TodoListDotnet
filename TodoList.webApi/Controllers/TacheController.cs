using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using TodoList.DataAccess;

namespace TodoList.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TacheController : ControllerBase
    {
        private readonly ILogger<TacheController> _logger;

        public TacheController(ILogger<TacheController> logger)
        {
            _logger = logger;
        }

        /* 
         
        ///<summary>
        /// Récuperation  des Roles 
        ///</summary> 
        [HttpGet]
        [Route("getAllTache")]
        public IEnumerable<Tache> GetTache()
        {
           
        }

        ///<summary>
        /// Récuperation  d'une Matiere par son ID 
        ///</summary> 
        [HttpGet]
        [Route("getTache/{id}")]
        public Tache GetTacheById(int id)
        {
           

        }

        ///<summary>
        /// Enregistré un role utilisateur
        ///</summary> 
        [HttpPost]
        [Route("addTache")]
        public IActionResult addTache([FromBody] Tache tache)
        {
            
        }

        ///<summary>
        /// Modification d'un role
        ///</summary> 
        [HttpPut]
        [Route("updateTache")]
        public IActionResult EditTache([FromBody] Tache tache)
        {

            
        }

        ///<summary>
        /// Suppression des infos d'une personne 
        ///</summary> 
        [HttpDelete]
        [Route("deleteRole/{id}")]
        public Boolean Deletetache(int id)
        {

        }

        */
    }
}
