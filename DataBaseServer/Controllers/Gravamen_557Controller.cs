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
    public class Gravamen_557Controller : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/Gravamen_557
        public IQueryable<Gravamen_557> GetGravamen_557 () {
            return db.Gravamen_557;
        }

        // GET: api/Gravamen_557/5
        [ResponseType(typeof(Gravamen_557))]
        public async Task<IHttpActionResult> GetGravamen_557 (int id) {
            Gravamen_557 gravamen_557 = await db.Gravamen_557.FindAsync(id);
            if (gravamen_557 == null) {
                return NotFound();
            }

            return Ok(gravamen_557);
        }

        // PUT: api/Gravamen_557/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutGravamen_557 (int id, Gravamen_557 gravamen_557) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != gravamen_557.id) {
                return BadRequest();
            }

            db.Entry(gravamen_557).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!Gravamen_557Exists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Gravamen_557
        [ResponseType(typeof(Gravamen_557))]
        public async Task<IHttpActionResult> PostGravamen_557 (Gravamen_557 gravamen_557) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Gravamen_557.Add(gravamen_557);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = gravamen_557.id }, gravamen_557);
        }

        // DELETE: api/Gravamen_557/5
        [ResponseType(typeof(Gravamen_557))]
        public async Task<IHttpActionResult> DeleteGravamen_557 (int id) {
            Gravamen_557 gravamen_557 = await db.Gravamen_557.FindAsync(id);
            if (gravamen_557 == null) {
                return NotFound();
            }

            db.Gravamen_557.Remove(gravamen_557);
            await db.SaveChangesAsync();

            return Ok(gravamen_557);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Gravamen_557Exists (int id) {
            return db.Gravamen_557.Count(e => e.id == id) > 0;
        }
    }
}