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
        private int kcal_zilnice;

        public Client(int id, string parola, string nume, string prenume, string adresa, string email,int kcal) {
        
            this.id_client = id;
            this.parola = parola;
            this.nume = nume;
            this.prenume = prenume;
            this.adresa = adresa;
            this.email = email;
            this.kcal_zilnice = kcal;
        
        }


    }
}
