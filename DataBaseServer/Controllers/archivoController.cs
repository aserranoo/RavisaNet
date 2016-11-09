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
    public class archivoController : ApiController {
        private PRDRavisa db = new PRDRavisa();

        // GET: api/archivo
        public IQueryable<archivo> Getarchivos () {
            return db.archivos;
        }

        // GET: api/archivo/5
        [ResponseType(typeof(archivo))]
        public async Task<IHttpActionResult> Getarchivo (int id) {
            archivo archivo = await db.archivos.FindAsync(id);
            if (archivo == null) {
                return NotFound();
            }

            return Ok(archivo);
        }

        // PUT: api/archivo/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putarchivo (int id, archivo archivo) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != archivo.id) {
                return BadRequest();
            }

            db.Entry(archivo).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!archivoExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/archivo
        [ResponseType(typeof(archivo))]
        public async Task<IHttpActionResult> Postarchivo (archivo archivo) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.archivos.Add(archivo);

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateException) {
                if (archivoExists(archivo.id)) {
                    return Conflict();
                } else {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = archivo.id }, archivo);
        }

        // DELETE: api/archivo/5
        [ResponseType(typeof(archivo))]
        public async Task<IHttpActionResult> Deletearchivo (int id) {
            archivo archivo = await db.archivos.FindAsync(id);
            if (archivo == null) {
                return NotFound();
            }

            db.archivos.Remove(archivo);
            await db.SaveChangesAsync();

            return Ok(archivo);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool archivoExists (int id) {
            return db.archivos.Count(e => e.id == id) > 0;
        }
    }
}