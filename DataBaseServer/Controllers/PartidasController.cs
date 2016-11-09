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
    public class PartidasController : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/Partidas
        public IQueryable<Partida> GetPartidas () {
            return db.Partidas;
        }

        // GET: api/Partidas/5
        [ResponseType(typeof(Partida))]
        public async Task<IHttpActionResult> GetPartida (int id) {
            Partida partida = await db.Partidas.FindAsync(id);
            if (partida == null) {
                return NotFound();
            }

            return Ok(partida);
        }

        // PUT: api/Partidas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPartida (int id, Partida partida) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != partida.Id) {
                return BadRequest();
            }

            db.Entry(partida).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!PartidaExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Partidas
        [ResponseType(typeof(Partida))]
        public async Task<IHttpActionResult> PostPartida (Partida partida) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Partidas.Add(partida);

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateException) {
                if (PartidaExists(partida.Id)) {
                    return Conflict();
                } else {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = partida.Id }, partida);
        }

        // DELETE: api/Partidas/5
        [ResponseType(typeof(Partida))]
        public async Task<IHttpActionResult> DeletePartida (int id) {
            Partida partida = await db.Partidas.FindAsync(id);
            if (partida == null) {
                return NotFound();
            }

            db.Partidas.Remove(partida);
            await db.SaveChangesAsync();

            return Ok(partida);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PartidaExists (int id) {
            return db.Partidas.Count(e => e.Id == id) > 0;
        }
    }
}