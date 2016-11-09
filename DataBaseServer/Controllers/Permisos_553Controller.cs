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
    public class Permisos_553Controller : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/Permisos_553
        public IQueryable<Permisos_553> GetPermisos_553 () {
            return db.Permisos_553;
        }

        // GET: api/Permisos_553/5
        [ResponseType(typeof(Permisos_553))]
        public async Task<IHttpActionResult> GetPermisos_553 (int id) {
            Permisos_553 permisos_553 = await db.Permisos_553.FindAsync(id);
            if (permisos_553 == null) {
                return NotFound();
            }

            return Ok(permisos_553);
        }

        // PUT: api/Permisos_553/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPermisos_553 (int id, Permisos_553 permisos_553) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != permisos_553.id) {
                return BadRequest();
            }

            db.Entry(permisos_553).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!Permisos_553Exists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Permisos_553
        [ResponseType(typeof(Permisos_553))]
        public async Task<IHttpActionResult> PostPermisos_553 (Permisos_553 permisos_553) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Permisos_553.Add(permisos_553);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = permisos_553.id }, permisos_553);
        }

        // DELETE: api/Permisos_553/5
        [ResponseType(typeof(Permisos_553))]
        public async Task<IHttpActionResult> DeletePermisos_553 (int id) {
            Permisos_553 permisos_553 = await db.Permisos_553.FindAsync(id);
            if (permisos_553 == null) {
                return NotFound();
            }

            db.Permisos_553.Remove(permisos_553);
            await db.SaveChangesAsync();

            return Ok(permisos_553);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Permisos_553Exists (int id) {
            return db.Permisos_553.Count(e => e.id == id) > 0;
        }
    }
}