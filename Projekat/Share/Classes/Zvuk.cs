using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share
{
    public class Zvuk : Objava
    {
        public string Path { get; set; }

        public Zvuk(int id, string naziv, string tip, int korisnikId, int brojSvidjanja,
            DateTime datumVrijeme, string path) : base(id, naziv, tip, korisnikId,  brojSvidjanja,
                datumVrijeme)
        {
            Path = path;
        }
    }
}
