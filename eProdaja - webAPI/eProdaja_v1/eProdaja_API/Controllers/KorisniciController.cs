using eProdaja_API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

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
            Korisnici k = db.Korisnici.Include(y => y.KorisniciUloge).Include(y => y.KorisniciUloge).Include("KorisniciUloge.Uloge").Single(y => y.KorisnikID == id);

            if (k == null)
            {
                return NotFound();
            }

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
            catch (Exception ex)
            {
                throw CreateHttpResponseMessage(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }

            foreach (var item in k.Uloge)
            {
                db.esp_KorisniciUloge_Insert(k.KorisnikID, item.UlogaID);
            }

            return CreatedAtRoute("DefaultApi", new { id = k.KorisnikID }, k);
        }

        private HttpResponseException CreateHttpResponseMessage(string reason, HttpStatusCode code)
        {
            HttpResponseMessage responseMessage = new HttpResponseMessage
            {
                Content = new StringContent(reason),
                ReasonPhrase = reason,
                StatusCode = code
            };

            return new HttpResponseException(responseMessage);
        }

        //PUT api/Korisnici/id

        [ResponseType(typeof(void))]
        public IHttpActionResult PutKorisnici(int id, Korisnici k)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != k.KorisnikID)
            {
                return BadRequest();
            }

            db.esp_Korisnici_Update(id, k.Ime, k.Prezime, k.Email,
                k.Telefon, k.KorisnickoIme, k.LozinkaSalt, k.LozinkaHash, k.Status);

            foreach (var x in k.Uloge)
            {
                db.esp_KorisniciUloge_Insert(k.KorisnikID, x.UlogaID);
            }

            foreach (var x in k.KorisniciUloge)
            {
                db.esp_KorisniciUloge_Delete(x.KorisnikUlogaID);
            }

            return StatusCode(HttpStatusCode.NoContent);
        }


        [HttpDelete]
        [Route("api/Korisnici/DeleteUser/{id}")]
        public IHttpActionResult DeleteKorisnici(int id)
        {
            Korisnici k = db.Korisnici.SingleOrDefault(x => x.KorisnikID == id);
            if (k == null)
            {
                return NotFound();
            }
            db.esp_Korisnici_Delete(id);
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