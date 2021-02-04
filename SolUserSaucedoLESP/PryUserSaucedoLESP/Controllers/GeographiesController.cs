using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PryUserSaucedoLESP.Models;

namespace PryUserSaucedoLESP.Controllers
{
    public class GeographiesController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Geographies
        public IQueryable<Geography> GetGeographies()
        {
            return db.Geographies;
        }

        // GET: api/Geographies/5
        [ResponseType(typeof(Geography))]
        public IHttpActionResult GetGeography(string id)
        {
            Geography geography = db.Geographies.Find(id);
            if (geography == null)
            {
                return NotFound();
            }

            return Ok(geography);
        }

        // PUT: api/Geographies/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGeography(string id, Geography geography)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != geography.Lat)
            {
                return BadRequest();
            }

            db.Entry(geography).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeographyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Geographies
        [ResponseType(typeof(Geography))]
        public IHttpActionResult PostGeography(Geography geography)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Geographies.Add(geography);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (GeographyExists(geography.Lat))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = geography.Lat }, geography);
        }

        // DELETE: api/Geographies/5
        [ResponseType(typeof(Geography))]
        public IHttpActionResult DeleteGeography(string id)
        {
            Geography geography = db.Geographies.Find(id);
            if (geography == null)
            {
                return NotFound();
            }

            db.Geographies.Remove(geography);
            db.SaveChanges();

            return Ok(geography);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GeographyExists(string id)
        {
            return db.Geographies.Count(e => e.Lat == id) > 0;
        }
    }
}