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
    public class Diferencias_702Controller : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/Diferencias_702
        public IQueryable<Diferencias_702> GetDiferencias_702 () {
            return db.Diferencias_702;
        }

        // GET: api/Diferencias_702/5
        [ResponseType(typeof(Diferencias_702))]
        public async Task<IHttpActionResult> GetDiferencias_702 (int id) {
            Diferencias_702 diferencias_702 = await db.Diferencias_702.FindAsync(id);
            if (diferencias_702 == null) {
                return NotFound();
            }

            return Ok(diferencias_702);
        }

        // PUT: api/Diferencias_702/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDiferencias_702 (int id, Diferencias_702 diferencias_702) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != diferencias_702.id) {
                return BadRequest();
            }

            db.Entry(diferencias_702).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!Diferencias_702Exists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Diferencias_702
        [ResponseType(typeof(Diferencias_702))]
        public async Task<IHttpActionResult> PostDiferencias_702 (Diferencias_702 diferencias_702) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Diferencias_702.Add(diferencias_702);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = diferencias_702.id }, diferencias_702);
        }

        // DELETE: api/Diferencias_702/5
        [ResponseType(typeof(Diferencias_702))]
        public async Task<IHttpActionResult> DeleteDiferencias_702 (int id) {
            Diferencias_702 diferencias_702 = await db.Diferencias_702.FindAsync(id);
            if (diferencias_702 == null) {
                return NotFound();
            }

            db.Diferencias_702.Remove(diferencias_702);
            await db.SaveChangesAsync();

            return Ok(diferencias_702);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Diferencias_702Exists (int id) {
            return db.Diferencias_702.Count(e => e.id == id) > 0;
        }
    }
}