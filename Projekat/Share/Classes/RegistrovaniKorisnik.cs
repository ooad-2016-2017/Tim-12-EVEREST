using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share
{
    public class RegistrovaniKorisnik : Osoba
    {
        private int id;
        private string username;
        private string password;
        private string email;
        public string Image { get; set; }

        public RegistrovaniKorisnik(string ime, string prezime, int id, string username,
            string password, string email, string image) : base(ime, prezime)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            Image = image;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                /** 
                 * @field-id se postavlja na vrijednost za 1 veću od vrijednosti posljednjeg 
                 * registrovanog korisnika.
                 * Vrijednost @field-id će se automatski dodijeliti korisniku pri registraciji.
                 */
                id = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                /**
                 * Potrebno je provjeriti da li je @param-username kojeg korisnik unosi validan.
                 * Ukoliko @param-username nije validan, korisnik se obavještava o neispravnom unosu.
                 */

                // Napisati provjeru

                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                /**
                 * Iz sigurnosnih razloga, @field-password mora sadržavati barem jedno veliko slovo,
                 * barem jedno malo slovo i barem jedan broj pri čemu dužina @field-password mora
                 * biti minimalno 5 znakova.
                 */

                // Napisati provjeru

                password = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                /**
                 * @field-email mora završavati sa "@hotmail.com" ili "@gmail.com".
                 * Također, @field-email ne može biti isti kao email nekog već registrovanog
                 * korisnika.
                 */
                
                // Napisati provjeru

                email = value;
            }
        }
    }
}
