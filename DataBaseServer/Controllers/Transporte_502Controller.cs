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
    public class Transporte_502Controller : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/Transporte_502
        public IQueryable<Transporte_502> GetTransporte_502 () {
            return db.Transporte_502;
        }

        // GET: api/Transporte_502/5
        [ResponseType(typeof(Transporte_502))]
        public async Task<IHttpActionResult> GetTransporte_502 (int id) {
            Transporte_502 transporte_502 = await db.Transporte_502.FindAsync(id);
            if (transporte_502 == null) {
                return NotFound();
            }

            return Ok(transporte_502);
        }

        // PUT: api/Transporte_502/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTransporte_502 (int id, Transporte_502 transporte_502) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != transporte_502.id) {
                return BadRequest();
            }

            db.Entry(transporte_502).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!Transporte_502Exists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Transporte_502
        [ResponseType(typeof(Transporte_502))]
        public async Task<IHttpActionResult> PostTransporte_502 (Transporte_502 transporte_502) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Transporte_502.Add(transporte_502);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = transporte_502.id }, transporte_502);
        }

        // DELETE: api/Transporte_502/5
        [ResponseType(typeof(Transporte_502))]
        public async Task<IHttpActionResult> DeleteTransporte_502 (int id) {
            Transporte_502 transporte_502 = await db.Transporte_502.FindAsync(id);
            if (transporte_502 == null) {
                return NotFound();
            }

            db.Transporte_502.Remove(transporte_502);
            await db.SaveChangesAsync();

            return Ok(transporte_502);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Transporte_502Exists (int id) {
            return db.Transporte_502.Count(e => e.id == id) > 0;
        }
    }
}