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
    public class Casos_554Controller : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/Casos_554
        public IQueryable<Casos_554> GetCasos_554 () {
            return db.Casos_554;
        }

        // GET: api/Casos_554/5
        [ResponseType(typeof(Casos_554))]
        public async Task<IHttpActionResult> GetCasos_554 (int id) {
            Casos_554 casos_554 = await db.Casos_554.FindAsync(id);
            if (casos_554 == null) {
                return NotFound();
            }

            return Ok(casos_554);
        }

        // PUT: api/Casos_554/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCasos_554 (int id, Casos_554 casos_554) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != casos_554.id) {
                return BadRequest();
            }

            db.Entry(casos_554).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!Casos_554Exists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Casos_554
        [ResponseType(typeof(Casos_554))]
        public async Task<IHttpActionResult> PostCasos_554 (Casos_554 casos_554) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Casos_554.Add(casos_554);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = casos_554.id }, casos_554);
        }

        // DELETE: api/Casos_554/5
        [ResponseType(typeof(Casos_554))]
        public async Task<IHttpActionResult> DeleteCasos_554 (int id) {
            Casos_554 casos_554 = await db.Casos_554.FindAsync(id);
            if (casos_554 == null) {
                return NotFound();
            }

            db.Casos_554.Remove(casos_554);
            await db.SaveChangesAsync();

            return Ok(casos_554);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Casos_554Exists (int id) {
            return db.Casos_554.Count(e => e.id == id) > 0;
        }
    }
}