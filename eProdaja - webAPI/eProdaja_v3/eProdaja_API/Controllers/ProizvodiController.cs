using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using eProdaja_API.Models;


namespace eProdaja_API.Controllers
{
    public class ProizvodiController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // POST api/Proizvodi
        [ResponseType(typeof(Proizvodi))]
        //[ExceptionFilter]
        public IHttpActionResult PostProizvod(Proizvodi p)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                p.ProizvodID = Convert.ToInt32(db.esp_Proizvodi_Insert(p.Naziv, p.Sifra, p.Cijena,
                                               p.VrstaID, p.JedinicaMjereID, p.Slika, p.SlikaThumb).FirstOrDefault());


                return CreatedAtRoute("DefaultApi", new { id = p.ProizvodID }, p);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;

                if (ex.InnerException != null)
                    msg = ex.InnerException.Message;

                throw CreateHttpResponseException(ex.InnerException.Message, HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet]
        [Route("api/Proizvodi/SearchByVrsta/{typeId}")]
        public List<Proizvodi_Result> SearchByVrsta(int typeId)
        {
            return db.esp_Proizvodi_SelectByVrsta(typeId).ToList();
        }

        private HttpResponseException CreateHttpResponseException(string reason, HttpStatusCode code)
        {
            HttpResponseMessage msg = new HttpResponseMessage()
            {
                StatusCode = code,
                ReasonPhrase = reason,
                Content = new StringContent(reason)
            };

            return new HttpResponseException(msg);
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
