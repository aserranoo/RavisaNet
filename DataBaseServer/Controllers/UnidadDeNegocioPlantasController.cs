using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DataBaseServer.Entities;
using System.Web.Http.Cors;

namespace DataBaseServer.Controllers {
    [EnableCors("http://localhost:9000", "*", "*")]
    public class UnidadDeNegocioPlantasController : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/UnidadDeNegocioPlantas
        public IQueryable<UnidadDeNegocioPlanta> GetUnidadDeNegocioPlantas () {
            return db.UnidadDeNegocioPlantas;
        }

        // GET: api/UnidadDeNegocioPlantas/5
        [ResponseType(typeof(UnidadDeNegocioPlanta))]
        public async Task<IHttpActionResult> GetUnidadDeNegocioPlanta (int id) {
            UnidadDeNegocioPlanta unidadDeNegocioPlanta = await db.UnidadDeNegocioPlantas.FindAsync(id);
            if (unidadDeNegocioPlanta == null) {
                return NotFound();
            }

            return Ok(unidadDeNegocioPlanta);
        }

        // PUT: api/UnidadDeNegocioPlantas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUnidadDeNegocioPlanta (int id, UnidadDeNegocioPlanta unidadDeNegocioPlanta) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != unidadDeNegocioPlanta.id) {
                return BadRequest();
            }

            db.Entry(unidadDeNegocioPlanta).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!UnidadDeNegocioPlantaExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/UnidadDeNegocioPlantas
        [ResponseType(typeof(UnidadDeNegocioPlanta))]
        public async Task<IHttpActionResult> PostUnidadDeNegocioPlanta (UnidadDeNegocioPlanta unidadDeNegocioPlanta) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.UnidadDeNegocioPlantas.Add(unidadDeNegocioPlanta);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = unidadDeNegocioPlanta.id }, unidadDeNegocioPlanta);
        }

        // DELETE: api/UnidadDeNegocioPlantas/5
        [ResponseType(typeof(UnidadDeNegocioPlanta))]
        public async Task<IHttpActionResult> DeleteUnidadDeNegocioPlanta (int id) {
            UnidadDeNegocioPlanta unidadDeNegocioPlanta = await db.UnidadDeNegocioPlantas.FindAsync(id);
            if (unidadDeNegocioPlanta == null) {
                return NotFound();
            }

            db.UnidadDeNegocioPlantas.Remove(unidadDeNegocioPlanta);
            await db.SaveChangesAsync();

            return Ok(unidadDeNegocioPlanta);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UnidadDeNegocioPlantaExists (int id) {
            return db.UnidadDeNegocioPlantas.Count(e => e.id == id) > 0;
        }
    }
}