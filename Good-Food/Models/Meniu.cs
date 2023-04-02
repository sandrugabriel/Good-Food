using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Good_Food.Models
{
    internal class Meniu
    {

        private int id_produs;
        private string denumire_produs;
        private string descriere;
        private int pret;
        private int kcal;
        private int felul;

        public Meniu(int  id_produs, string denumire_produs, string descriere,int pret, int kcal, int felul)
        {

            this.id_produs = id_produs;
            this.denumire_produs = denumire_produs;
            this.descriere = descriere;
            this.pret = pret;
            this.kcal = kcal;
            this.felul = felul;

        }

        public Meniu(string textul)
        {

            string[] prop = textul.Split(';');

            this.id_produs = int.Parse(prop[0]);
            this.denumire_produs = prop[1];
            this.descriere = prop[2];
            this.pret = int.Parse(prop[3]);
            this.kcal = int.Parse(prop[4]);
            this.felul = int.Parse(prop[5]);

        }

    }
}
