using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share
{
    class Objava
    {
        private int id;
        public string Naziv { get; set; }
        // Tip objave može biti: slika, zvuk ili video.
        public string Tip { get; set; }
        private int korisnikId;
        public int BrojSvidjanja { get; set; }
        // Predstavlja datum i vrijeme kada je objava kreirana
        private DateTime datumVrijeme; 

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                /** 
                 * @field-id se postavlja na vrijednost za 1 veću od vrijednosti id-a posljednje
                 * kreirane objave.
                 * Vrijednost @field-id će se automatski dodijeliti objavi pri kreiranju.
                 */
                id = value;
            }
        }

        public int KorisnikId
        {
            get
            {
                return korisnikId;
            }
            set
            {
                /**
                 * Objavu kreiraju registrovani korisnici tako da, kada se objava kreira,
                 * znamo id korisnika koji je tu objavu kreirao (objavio).
                 */
                korisnikId = value;
            }
        }

        public DateTime DatumVrijeme
        {
            get
            {
                return datumVrijeme;
            }
            set
            {
                /**
                 * @field-datumVrijeme mora biti validna vrijednost, a bit će validna
                 * jer će se ova vrijednost automatski kreirati kada korisnik želi
                 * kreirati neku objavu.
                 */
                datumVrijeme = value;
            }
        }
    }
}
