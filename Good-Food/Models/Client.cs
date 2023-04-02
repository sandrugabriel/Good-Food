using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Good_Food.Models
{
    internal class Client
    {

        private int id_client;
        private string parola;
        private string nume;
        private string prenume;
        private string adresa;
        private string email;

        public Client(int id, string parola, string nume, string prenume, string adresa, string email) {
        
            this.id_client = id;
            this.parola = parola;
            this.nume = nume;
            this.prenume = prenume;
            this.adresa = adresa;
            this.email = email;
        
        }

        public Client(string textul)
        {

            string[] prop = textul.Split(';');

            this.id_client = int.Parse(prop[0]);
            this.parola = prop[1];
            this.nume = prop[2];
            this.prenume = prop[3];
            this.adresa = prop[4];
            this.email = prop[5];

        }

        public int getid_Client()
        {

            return id_client;
        }

        public string getparola()
        {
            return parola;
        }

        public string getnume()
        {
            return nume;
        }

        public string getprenume()
        {
            return prenume;
        }

        public string getadresa()
        {
            return adresa;
        }

        public string getEmail()
        {
            return email;
        }


    }
}
