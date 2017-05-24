using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share
{
    public class Slika : Objava
    {
        public string Url { get; set; }

        public Slika(int id, string naziv, string tip, int korisnikId, int brojSvidjanja, 
            DateTime datumVrijeme, string url) : base(id, naziv, tip, korisnikId,  brojSvidjanja,
                datumVrijeme)
        {
            Url = url;
        }
    }
}
