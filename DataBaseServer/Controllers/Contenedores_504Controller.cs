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
    public class Contenedores_504Controller : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/Contenedores_504
        public IQueryable<Contenedores_504> GetContenedores_504 () {
            return db.Contenedores_504;
        }

        // GET: api/Contenedores_504/5
        [ResponseType(typeof(Contenedores_504))]
        public async Task<IHttpActionResult> GetContenedores_504 (int id) {
            Contenedores_504 contenedores_504 = await db.Contenedores_504.FindAsync(id);
            if (contenedores_504 == null) {
                return NotFound();
            }

            return Ok(contenedores_504);
        }

        // PUT: api/Contenedores_504/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutContenedores_504 (int id, Contenedores_504 contenedores_504) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != contenedores_504.id) {
                return BadRequest();
            }

            db.Entry(contenedores_504).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!Contenedores_504Exists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Contenedores_504
        [ResponseType(typeof(Contenedores_504))]
        public async Task<IHttpActionResult> PostContenedores_504 (Contenedores_504 contenedores_504) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Contenedores_504.Add(contenedores_504);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = contenedores_504.id }, contenedores_504);
        }

        // DELETE: api/Contenedores_504/5
        [ResponseType(typeof(Contenedores_504))]
        public async Task<IHttpActionResult> DeleteContenedores_504 (int id) {
            Contenedores_504 contenedores_504 = await db.Contenedores_504.FindAsync(id);
            if (contenedores_504 == null) {
                return NotFound();
            }

            db.Contenedores_504.Remove(contenedores_504);
            await db.SaveChangesAsync();

            return Ok(contenedores_504);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Contenedores_504Exists (int id) {
            return db.Contenedores_504.Count(e => e.id == id) > 0;
        }
    }
}