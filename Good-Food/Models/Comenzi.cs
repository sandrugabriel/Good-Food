using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Good_Food.Models
{
    internal class Comenzi
    {
        public struct Date
        {
            int luna;
            int ziua;
            int anul;
            int ora;
            int minutul;
            int secunda;
        }

        private int id_comanda;
        private int id_client;
        private Date date_comenzi;

        public Comenzi(int id_comanda, int id_client, Date date)
        {
            this.id_client = id_client;
            this.id_client = id_client;
            this.date_comenzi = date;

        }


    }
}
