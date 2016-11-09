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
    public class Pedimentos_GlobalController : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/Pedimentos_Global
        public IQueryable<Pedimentos_Global> GetPedimentos_Global () {
            return db.Pedimentos_Global;
        }

        // GET: api/Pedimentos_Global/5
        [ResponseType(typeof(Pedimentos_Global))]
        public async Task<IHttpActionResult> GetPedimentos_Global (int id) {
            Pedimentos_Global pedimentos_Global = await db.Pedimentos_Global.FindAsync(id);
            if (pedimentos_Global == null) {
                return NotFound();
            }

            return Ok(pedimentos_Global);
        }

        // PUT: api/Pedimentos_Global/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPedimentos_Global (int id, Pedimentos_Global pedimentos_Global) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != pedimentos_Global.Id) {
                return BadRequest();
            }

            db.Entry(pedimentos_Global).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!Pedimentos_GlobalExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Pedimentos_Global
        [ResponseType(typeof(Pedimentos_Global))]
        public async Task<IHttpActionResult> PostPedimentos_Global (Pedimentos_Global pedimentos_Global) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Pedimentos_Global.Add(pedimentos_Global);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = pedimentos_Global.Id }, pedimentos_Global);
        }

        // DELETE: api/Pedimentos_Global/5
        [ResponseType(typeof(Pedimentos_Global))]
        public async Task<IHttpActionResult> DeletePedimentos_Global (int id) {
            Pedimentos_Global pedimentos_Global = await db.Pedimentos_Global.FindAsync(id);
            if (pedimentos_Global == null) {
                return NotFound();
            }

            db.Pedimentos_Global.Remove(pedimentos_Global);
            await db.SaveChangesAsync();

            return Ok(pedimentos_Global);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Pedimentos_GlobalExists (int id) {
            return db.Pedimentos_Global.Count(e => e.Id == id) > 0;
        }
    }
}