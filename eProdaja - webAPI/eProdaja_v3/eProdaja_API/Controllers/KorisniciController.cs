using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using eProdaja_API.Models;
using eProdaja_API.Util;

namespace eProdaja_API.Controllers
{
    public class KorisniciController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        //GET api/Korisnici/id

        [HttpGet]
        [ResponseType(typeof(Korisnici))]
        public IHttpActionResult GetKorisnici(int id)
        {
            Korisnici k = db.Korisnici.Find(id);

            if (k == null)
                return NotFound();

            return Ok(k);
        }

        //GET api/Korisnici/SearchKorisnici
        [HttpGet]
        [Route("api/Korisnici/SearchByName/{name?}")]
        public List<Korisnici_Result> SearchByName(string name = "")
        {
            return db.esp_Korisnici_SelectByImePrezime(name).ToList();
        }

        // GET api/Korisnici/username
        [ResponseType(typeof(Korisnici))]
        [Route("api/Korisnici/GetByUsername/{username}")]
        public IHttpActionResult GetByUsername(string username)
        {
            Korisnici korisnici = db.esp_Korisnici_SelectByKorisnickoIme(username).FirstOrDefault();

            if (korisnici == null)
            {
                return NotFound();
            }

            return Ok(korisnici);
        }

        // POST api/Korisnici
        [ResponseType(typeof(Korisnici))]
        //[ExceptionFilter]
        public IHttpActionResult PostKorisnici(Korisnici k)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            /*  SqlException: Violation of UNIQUE KEY constraint 'CS_KorisnickoIme'.Cannot insert
             *  duplicate key in object 'dbo.Korisnici'.The duplicate key value is (larisa).*/

            try
            {
                k.KorisnikID = Convert.ToInt32(db.esp_Korisnici_Insert(k.Ime, k.Prezime, k.Email,
                       k.Telefon, k.KorisnickoIme, k.LozinkaSalt, k.LozinkaHash).FirstOrDefault());
            }
            catch (EntityException ex)
            {
                //throw new NotImplementedException();
                if(ex.InnerException != null)
                    throw CreateHttpExceptionMessage(Util.ExceptionHandler.HandleException(ex),
                                                     HttpStatusCode.Conflict);
            }

            foreach (var item in k.Uloge)
            {
                db.esp_KorisniciUloge_Insert(k.KorisnikID, item.UlogaID);
            }
       
           return CreatedAtRoute("DefaultApi", new { id = k.KorisnikID }, k);
        }

        private HttpResponseException CreateHttpExceptionMessage(string reason, HttpStatusCode code)
        {
            HttpResponseMessage msg = new HttpResponseMessage()
            {
               ReasonPhrase = reason,
               StatusCode = code,
               Content = new StringContent(reason)
            };

            return new HttpResponseException(msg);
        }

        //PUT api/Korisnici/id

        [ResponseType(typeof(void))]
        public IHttpActionResult PutKorisnici(int id, Korisnici k)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != k.KorisnikID)
                return BadRequest();

            db.esp_Korisnici_Update(id, k.Ime, k.Prezime, k.Email, 
                k.Telefon, k.KorisnickoIme, k.LozinkaSalt, k.LozinkaHash, k.Status);

            return StatusCode(HttpStatusCode.NoContent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }

    }
}