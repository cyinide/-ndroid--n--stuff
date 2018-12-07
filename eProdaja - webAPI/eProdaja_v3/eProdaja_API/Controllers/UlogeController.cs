using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using eProdaja_API.Models;

namespace eProdaja_API.Controllers
{
    public class UlogeController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        //api/Uloge
        public List<Uloge> GetUloge()
        {
            return db.Uloge.OrderBy(x => x.Naziv).ToList();
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
