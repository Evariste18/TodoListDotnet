using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using TodoList.DataAccess.Models;
using TodoList.BusinessLogic.Interfaces;

namespace TodoList.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TacheController : ControllerBase
    {
        private readonly ILogger<TacheController> _logger;
        private readonly ITache Itache;

        public TacheController(ILogger<TacheController> logger, ITache tache)
        {
            _logger = logger; 
            Itache = tache;
        }

       
         
        ///<summary>
        /// Récuperation  de toutes les taches
        ///</summary> 
        [HttpGet]
        [Route("getAllTache")]
        public IActionResult GetTache(int page, int pageSize)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Error");
            }
            else
            {
                return Ok(this.Itache.GetTache(page,pageSize));
            }
        }

       

        ///<summary>
        /// Récuperation  d'une tache par son ID 
        ///</summary> 
        [HttpGet]
        [Route("getTache/{id}")]
        public IActionResult GetTacheById(int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Error");
            }
            else
            {
                return Ok(this.Itache.GetTacheById(id));
            }
        }

   
        ///<summary>
        /// Enregistré une tache
        ///</summary> 
        [HttpPost]
        [Route("addTache")]
        public IActionResult addTache([FromBody] Tache task)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Erreur d'enregistrement");
            }
            else
            {
                return Ok(this.Itache.AddTache(task));
            }
            
        }

            
        ///<summary>
        /// Modification d'es infos d'une tache
        ///</summary> 
        [HttpPut]
        [Route("updateTache")]
        public IActionResult EditTache([FromBody] Tache task)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Erreur de mise à jour");
            }
            else
            {
                return Ok(this.Itache.UpdateTache(task));
            }
            
        }
  
        ///<summary>
        /// Suppression d'une tache
        ///</summary> 
        [HttpDelete]
        [Route("deleteTache/{id}")]
        public Boolean Deletetache(int id)
        {
           
            return this.Itache.DeleteTache(id);
           
        }

    }
}
