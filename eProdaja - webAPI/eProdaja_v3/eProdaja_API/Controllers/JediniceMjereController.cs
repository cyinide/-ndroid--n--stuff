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
using eProdaja_API.Models;

namespace eProdaja_API.Controllers
{
    public class JediniceMjereController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        //api/JediniceMjere
        public List<JediniceMjere> GetJediniceMjere()
        {
            return db.JediniceMjere.OrderBy(x => x.Naziv).ToList();
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