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
    public class PedimentosController : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/Pedimentos
        public IQueryable<Pedimento> GetPedimentos () {
            return db.Pedimentos;
        }

        // GET: api/Pedimentos/5
        [ResponseType(typeof(Pedimento))]
        public async Task<IHttpActionResult> GetPedimento (int id) {
            Pedimento pedimento = await db.Pedimentos.FindAsync(id);
            if (pedimento == null) {
                return NotFound();
            }

            return Ok(pedimento);
        }

        // PUT: api/Pedimentos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPedimento (int id, Pedimento pedimento) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != pedimento.id) {
                return BadRequest();
            }

            db.Entry(pedimento).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!PedimentoExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Pedimentos
        [ResponseType(typeof(Pedimento))]
        public async Task<IHttpActionResult> PostPedimento (Pedimento pedimento) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Pedimentos.Add(pedimento);

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateException) {
                if (PedimentoExists(pedimento.id)) {
                    return Conflict();
                } else {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = pedimento.id }, pedimento);
        }

        // DELETE: api/Pedimentos/5
        [ResponseType(typeof(Pedimento))]
        public async Task<IHttpActionResult> DeletePedimento (int id) {
            Pedimento pedimento = await db.Pedimentos.FindAsync(id);
            if (pedimento == null) {
                return NotFound();
            }

            db.Pedimentos.Remove(pedimento);
            await db.SaveChangesAsync();

            return Ok(pedimento);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PedimentoExists (int id) {
            return db.Pedimentos.Count(e => e.id == id) > 0;
        }
    }
}