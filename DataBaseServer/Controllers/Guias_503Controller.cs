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
    public class Guias_503Controller : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/Guias_503
        public IQueryable<Guias_503> GetGuias_503 () {
            return db.Guias_503;
        }

        // GET: api/Guias_503/5
        [ResponseType(typeof(Guias_503))]
        public async Task<IHttpActionResult> GetGuias_503 (int id) {
            Guias_503 guias_503 = await db.Guias_503.FindAsync(id);
            if (guias_503 == null) {
                return NotFound();
            }

            return Ok(guias_503);
        }

        // PUT: api/Guias_503/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutGuias_503 (int id, Guias_503 guias_503) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != guias_503.id) {
                return BadRequest();
            }

            db.Entry(guias_503).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!Guias_503Exists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Guias_503
        [ResponseType(typeof(Guias_503))]
        public async Task<IHttpActionResult> PostGuias_503 (Guias_503 guias_503) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Guias_503.Add(guias_503);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = guias_503.id }, guias_503);
        }

        // DELETE: api/Guias_503/5
        [ResponseType(typeof(Guias_503))]
        public async Task<IHttpActionResult> DeleteGuias_503 (int id) {
            Guias_503 guias_503 = await db.Guias_503.FindAsync(id);
            if (guias_503 == null) {
                return NotFound();
            }

            db.Guias_503.Remove(guias_503);
            await db.SaveChangesAsync();

            return Ok(guias_503);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Guias_503Exists (int id) {
            return db.Guias_503.Count(e => e.id == id) > 0;
        }
    }
}