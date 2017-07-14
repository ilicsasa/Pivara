using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Pvara.Models;
using Pvara.Inerface;
using AutoMapper.QueryableExtensions;
using Pvara.Repository;

namespace Pvara.Controllers
{
    public class VrstePivasController : ApiController
    {
        IVrstePivaRepository _repository;

        public VrstePivasController(IVrstePivaRepository repository)
        {
            _repository = repository;
        }

      
        // GET: api/VrstePivas
        public IEnumerable<VrstePiva> GetVrstePivas()
        {
            return _repository.GetAll();
        }


        // GET: api/VrstePivas/1
        [ResponseType(typeof(VrstePiva))]
        public IHttpActionResult GetById(int id)
        {
            VrstePiva vrstePiva = _repository.GetById(id);
            if (vrstePiva == null)
            {
                return NotFound();
            }

            return Ok(vrstePiva);
        }

        // PUT: api/VrstePivas/5
        [ResponseType(typeof(VrstePiva))]
        public IHttpActionResult PutVrstePiva(int id, VrstePiva vrstePiva)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vrstePiva.Id)
            {
                return BadRequest();
            }
            
            try
            {
                _repository.Edit(vrstePiva);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VrstePivaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

               
        // POST: api/VrstePivas
        [ResponseType(typeof(VrstePiva))]
        public IHttpActionResult PostVrstePiva(VrstePiva vrstePiva)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _repository.Create(vrstePiva);
            return CreatedAtRoute("DefaultApi", new { Id = vrstePiva.Id }, vrstePiva);
                        
        }

        private bool VrstePivaExists(int id)
        {
            return _repository.GetById(id) != null;
        }
        
        // DELETE: api/VrstePivas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult DeleteVrstePiva(int id)
        {
            VrstePiva vrstePiva = _repository.GetById(id);
            if (vrstePiva == null)
            {
                return BadRequest();
            }

            _repository.Delete(vrstePiva);

            return Ok();
        }
                                
    }
}