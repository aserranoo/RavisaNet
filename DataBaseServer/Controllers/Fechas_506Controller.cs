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
    public class Fechas_506Controller : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/Fechas_506
        public IQueryable<Fechas_506> GetFechas_506 () {
            return db.Fechas_506;
        }

        // GET: api/Fechas_506/5
        [ResponseType(typeof(Fechas_506))]
        public async Task<IHttpActionResult> GetFechas_506 (int id) {
            Fechas_506 fechas_506 = await db.Fechas_506.FindAsync(id);
            if (fechas_506 == null) {
                return NotFound();
            }

            return Ok(fechas_506);
        }

        // PUT: api/Fechas_506/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutFechas_506 (int id, Fechas_506 fechas_506) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != fechas_506.id) {
                return BadRequest();
            }

            db.Entry(fechas_506).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!Fechas_506Exists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Fechas_506
        [ResponseType(typeof(Fechas_506))]
        public async Task<IHttpActionResult> PostFechas_506 (Fechas_506 fechas_506) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Fechas_506.Add(fechas_506);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = fechas_506.id }, fechas_506);
        }

        // DELETE: api/Fechas_506/5
        [ResponseType(typeof(Fechas_506))]
        public async Task<IHttpActionResult> DeleteFechas_506 (int id) {
            Fechas_506 fechas_506 = await db.Fechas_506.FindAsync(id);
            if (fechas_506 == null) {
                return NotFound();
            }

            db.Fechas_506.Remove(fechas_506);
            await db.SaveChangesAsync();

            return Ok(fechas_506);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Fechas_506Exists (int id) {
            return db.Fechas_506.Count(e => e.id == id) > 0;
        }
    }
}