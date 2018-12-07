using eProdaja_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_UI
{
    public static class Global
    {
        public static Korisnici prijavljeniKorisnik { get; set; }

        #region API Routes

        public const string KorisniciRoute = "api/Korisnici";
        public const string UlogeRoute = "api/Uloge";

        #endregion
    }
}
