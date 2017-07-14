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

namespace Pvara.Controllers
{
    public class PivoesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Pivoes
        public IQueryable<Pivo> GetPivos()
        {
            return db.Pivos;
        }

        // GET: api/Pivoes/5
        [ResponseType(typeof(Pivo))]
        public IHttpActionResult GetPivo(int id)
        {
            Pivo pivo = db.Pivos.Find(id);
            if (pivo == null)
            {
                return NotFound();
            }

            return Ok(pivo);
        }

        // PUT: api/Pivoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPivo(int id, Pivo pivo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pivo.Id)
            {
                return BadRequest();
            }

            db.Entry(pivo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PivoExists(id))
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

        // POST: api/Pivoes
        [ResponseType(typeof(Pivo))]
        public IHttpActionResult PostPivo(Pivo pivo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pivos.Add(pivo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pivo.Id }, pivo);
        }

        // DELETE: api/Pivoes/5
        [ResponseType(typeof(Pivo))]
        public IHttpActionResult DeletePivo(int id)
        {
            Pivo pivo = db.Pivos.Find(id);
            if (pivo == null)
            {
                return NotFound();
            }

            db.Pivos.Remove(pivo);
            db.SaveChanges();

            return Ok(pivo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PivoExists(int id)
        {
            return db.Pivos.Count(e => e.Id == id) > 0;
        }
    }
}