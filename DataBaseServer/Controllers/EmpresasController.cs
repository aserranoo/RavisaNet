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
    public class EmpresasController : ApiController {
        private RavisaContext db = new RavisaContext();

        // GET: api/Empresas
        public IQueryable<Empresa> GetEmpresas () {
            return db.Empresas;
        }

        // GET: api/Empresas/5
        [ResponseType(typeof(Empresa))]
        public async Task<IHttpActionResult> GetEmpresa (int id) {
            Empresa empresa = await db.Empresas.FindAsync(id);
            if (empresa == null) {
                return NotFound();
            }

            return Ok(empresa);
        }

        // PUT: api/Empresas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEmpresa (int id, Empresa empresa) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != empresa.EmpresaId) {
                return BadRequest();
            }

            db.Entry(empresa).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!EmpresaExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Empresas
        [ResponseType(typeof(Empresa))]
        public async Task<IHttpActionResult> PostEmpresa (Empresa empresa) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Empresas.Add(empresa);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = empresa.EmpresaId }, empresa);
        }

        // DELETE: api/Empresas/5
        [ResponseType(typeof(Empresa))]
        public async Task<IHttpActionResult> DeleteEmpresa (int id) {
            Empresa empresa = await db.Empresas.FindAsync(id);
            if (empresa == null) {
                return NotFound();
            }

            db.Empresas.Remove(empresa);
            await db.SaveChangesAsync();

            return Ok(empresa);
        }

        protected override void Dispose (bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmpresaExists (int id) {
            return db.Empresas.Count(e => e.EmpresaId == id) > 0;
        }
    }
}