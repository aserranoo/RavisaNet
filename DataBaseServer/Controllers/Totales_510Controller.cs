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
    public class Totales_510Controller : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/Totales_510
        public IQueryable<Totales_510> GetTotales_510 () {
            return db.Totales_510;
        }

        // GET: api/Totales_510/5
        [ResponseType(typeof(Totales_510))]
        public async Task<IHttpActionResult> GetTotales_510 (int id) {
            Totales_510 totales_510 = await db.Totales_510.FindAsync(id);
            if (totales_510 == null) {
                return NotFound();
            }

            return Ok(totales_510);
        }

        // PUT: api/Totales_510/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTotales_510 (int id, Totales_510 totales_510) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != totales_510.id) {
                return BadRequest();
            }

            db.Entry(totales_510).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!Totales_510Exists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Totales_510
        [ResponseType(typeof(Totales_510))]
        public async Task<IHttpActionResult> PostTotales_510 (Totales_510 totales_510) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Totales_510.Add(totales_510);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = totales_510.id }, totales_510);
        }

        // DELETE: api/Totales_510/5
        [ResponseType(typeof(Totales_510))]
        public async Task<IHttpActionResult> DeleteTotales_510 (int id) {
            Totales_510 totales_510 = await db.Totales_510.FindAsync(id);
            if (totales_510 == null) {
                return NotFound();
            }

            db.Totales_510.Remove(totales_510);
            await db.SaveChangesAsync();

            return Ok(totales_510);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Totales_510Exists (int id) {
            return db.Totales_510.Count(e => e.id == id) > 0;
        }
    }
}