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
    public class PartidaContrib_556Controller : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/PartidaContrib_556
        public IQueryable<PartidaContrib_556> GetPartidaContrib_556 () {
            return db.PartidaContrib_556;
        }

        // GET: api/PartidaContrib_556/5
        [ResponseType(typeof(PartidaContrib_556))]
        public async Task<IHttpActionResult> GetPartidaContrib_556 (int id) {
            PartidaContrib_556 partidaContrib_556 = await db.PartidaContrib_556.FindAsync(id);
            if (partidaContrib_556 == null) {
                return NotFound();
            }

            return Ok(partidaContrib_556);
        }

        // PUT: api/PartidaContrib_556/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPartidaContrib_556 (int id, PartidaContrib_556 partidaContrib_556) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != partidaContrib_556.id) {
                return BadRequest();
            }

            db.Entry(partidaContrib_556).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!PartidaContrib_556Exists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/PartidaContrib_556
        [ResponseType(typeof(PartidaContrib_556))]
        public async Task<IHttpActionResult> PostPartidaContrib_556 (PartidaContrib_556 partidaContrib_556) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.PartidaContrib_556.Add(partidaContrib_556);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = partidaContrib_556.id }, partidaContrib_556);
        }

        // DELETE: api/PartidaContrib_556/5
        [ResponseType(typeof(PartidaContrib_556))]
        public async Task<IHttpActionResult> DeletePartidaContrib_556 (int id) {
            PartidaContrib_556 partidaContrib_556 = await db.PartidaContrib_556.FindAsync(id);
            if (partidaContrib_556 == null) {
                return NotFound();
            }

            db.PartidaContrib_556.Remove(partidaContrib_556);
            await db.SaveChangesAsync();

            return Ok(partidaContrib_556);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PartidaContrib_556Exists (int id) {
            return db.PartidaContrib_556.Count(e => e.id == id) > 0;
        }
    }
}