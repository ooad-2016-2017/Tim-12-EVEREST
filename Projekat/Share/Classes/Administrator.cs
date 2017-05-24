using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share
{
    public class Administrator : RegistrovaniKorisnik
    {
        public Administrator(string ime, string prezime, int id, string username,
            string password, string email, string image) : base(ime, prezime, id, username, 
                password, email, image)
        {

        }
    }
}
