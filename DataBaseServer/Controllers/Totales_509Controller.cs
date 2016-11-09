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
    public class Totales_509Controller : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/Totales_509
        public IQueryable<Totales_509> GetTotales_509 () {
            return db.Totales_509;
        }

        // GET: api/Totales_509/5
        [ResponseType(typeof(Totales_509))]
        public async Task<IHttpActionResult> GetTotales_509 (int id) {
            Totales_509 totales_509 = await db.Totales_509.FindAsync(id);
            if (totales_509 == null) {
                return NotFound();
            }

            return Ok(totales_509);
        }

        // PUT: api/Totales_509/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTotales_509 (int id, Totales_509 totales_509) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != totales_509.id) {
                return BadRequest();
            }

            db.Entry(totales_509).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!Totales_509Exists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Totales_509
        [ResponseType(typeof(Totales_509))]
        public async Task<IHttpActionResult> PostTotales_509 (Totales_509 totales_509) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Totales_509.Add(totales_509);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = totales_509.id }, totales_509);
        }

        // DELETE: api/Totales_509/5
        [ResponseType(typeof(Totales_509))]
        public async Task<IHttpActionResult> DeleteTotales_509 (int id) {
            Totales_509 totales_509 = await db.Totales_509.FindAsync(id);
            if (totales_509 == null) {
                return NotFound();
            }

            db.Totales_509.Remove(totales_509);
            await db.SaveChangesAsync();

            return Ok(totales_509);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Totales_509Exists (int id) {
            return db.Totales_509.Count(e => e.id == id) > 0;
        }
    }
}