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
    public class Casos_507Controller : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/Casos_507
        public IQueryable<Casos_507> GetCasos_507 () {
            return db.Casos_507;
        }

        // GET: api/Casos_507/5
        [ResponseType(typeof(Casos_507))]
        public async Task<IHttpActionResult> GetCasos_507 (int id) {
            Casos_507 casos_507 = await db.Casos_507.FindAsync(id);
            if (casos_507 == null) {
                return NotFound();
            }

            return Ok(casos_507);
        }

        // PUT: api/Casos_507/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCasos_507 (int id, Casos_507 casos_507) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != casos_507.id) {
                return BadRequest();
            }

            db.Entry(casos_507).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!Casos_507Exists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Casos_507
        [ResponseType(typeof(Casos_507))]
        public async Task<IHttpActionResult> PostCasos_507 (Casos_507 casos_507) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Casos_507.Add(casos_507);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = casos_507.id }, casos_507);
        }

        // DELETE: api/Casos_507/5
        [ResponseType(typeof(Casos_507))]
        public async Task<IHttpActionResult> DeleteCasos_507 (int id) {
            Casos_507 casos_507 = await db.Casos_507.FindAsync(id);
            if (casos_507 == null) {
                return NotFound();
            }

            db.Casos_507.Remove(casos_507);
            await db.SaveChangesAsync();

            return Ok(casos_507);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Casos_507Exists (int id) {
            return db.Casos_507.Count(e => e.id == id) > 0;
        }
    }
}