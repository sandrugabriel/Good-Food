using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Good_Food.Models
{
    internal class SubComenzi
    {

        private int id_subcomanda;
        private int id_comanda;
        private int id_produs;
        private int cantitate;

        public SubComenzi(int id_subcomanda, int id_comanda, int id_produs, int cantitate)
        {
            this.id_subcomanda = id_subcomanda;
            this.id_comanda = id_comanda;
            this.id_produs = id_produs;
            this.cantitate = cantitate;
        }
    }
}
