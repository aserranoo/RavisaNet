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
    public class Observaciones_558Controller : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/Observaciones_558
        public IQueryable<Observaciones_558> GetObservaciones_558 () {
            return db.Observaciones_558;
        }

        // GET: api/Observaciones_558/5
        [ResponseType(typeof(Observaciones_558))]
        public async Task<IHttpActionResult> GetObservaciones_558 (int id) {
            Observaciones_558 observaciones_558 = await db.Observaciones_558.FindAsync(id);
            if (observaciones_558 == null) {
                return NotFound();
            }

            return Ok(observaciones_558);
        }

        // PUT: api/Observaciones_558/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutObservaciones_558 (int id, Observaciones_558 observaciones_558) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != observaciones_558.id) {
                return BadRequest();
            }

            db.Entry(observaciones_558).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!Observaciones_558Exists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Observaciones_558
        [ResponseType(typeof(Observaciones_558))]
        public async Task<IHttpActionResult> PostObservaciones_558 (Observaciones_558 observaciones_558) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Observaciones_558.Add(observaciones_558);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = observaciones_558.id }, observaciones_558);
        }

        // DELETE: api/Observaciones_558/5
        [ResponseType(typeof(Observaciones_558))]
        public async Task<IHttpActionResult> DeleteObservaciones_558 (int id) {
            Observaciones_558 observaciones_558 = await db.Observaciones_558.FindAsync(id);
            if (observaciones_558 == null) {
                return NotFound();
            }

            db.Observaciones_558.Remove(observaciones_558);
            await db.SaveChangesAsync();

            return Ok(observaciones_558);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Observaciones_558Exists (int id) {
            return db.Observaciones_558.Count(e => e.id == id) > 0;
        }
    }
}