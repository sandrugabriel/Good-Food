using Good_Food.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_Food.Controllers
{
    internal class ControllerMeniu
    {
        List<Meniu> meniuri;

        public ControllerMeniu()
        {

            meniuri = new List<Meniu>();

            load();

        }

        public void load()
        {
            string path = Application.StartupPath + @"/data/meniuri.txt";
            StreamReader stream = new StreamReader(path);

            string textul;

            while((textul = stream.ReadLine()) != null)
            {

                Meniu meniu = new Meniu(textul);
                meniuri.Add(meniu);
            }

            stream.Close();

        }

        public void createList(ListView listMeniuri)
        {

            listMeniuri.Clear();

            listMeniuri.Columns.Add("Id", 65, HorizontalAlignment.Left);
            listMeniuri.Columns.Add("Denumire", 100, HorizontalAlignment.Left);
            listMeniuri.Columns.Add("Descriere", 120, HorizontalAlignment.Left);
            listMeniuri.Columns.Add("Pret",75, HorizontalAlignment.Left);
            listMeniuri.Columns.Add("Kcal", 85, HorizontalAlignment.Left);
            listMeniuri.Columns.Add("Felul", 95, HorizontalAlignment.Left);
            listMeniuri.Columns.Add("Cantitatea", 95, HorizontalAlignment.Left);
            listMeniuri.Columns.Add("Adauga", 130, HorizontalAlignment.Left);

            foreach(Meniu meniu in meniuri)
            {
                NumericUpDown nrCantitatea = new NumericUpDown();
                nrCantitatea.Maximum = 999;
                nrCantitatea.Size = new System.Drawing.Size(50, 30);
                nrCantitatea.Font = new Font("Cambia", 9);

                Button btnAdd = new Button();
                btnAdd.Click += new EventHandler(btnAdd_Click);
                btnAdd.Text = "Adauga";
                btnAdd.Name = "btnAdd";
                btnAdd.Font = new Font("Cambia",9); 
                btnAdd.Size = new System.Drawing.Size(50, 30);

                ListViewItem linie = new ListViewItem();
                linie.Text = meniu.getId_produs().ToString();
                linie.SubItems.Add(meniu.getDenumire_produs());
                linie.SubItems.Add(meniu.getDescriere());
                linie.SubItems.Add(meniu.getPret().ToString());
                linie.SubItems.Add(meniu.getFelul().ToString());
                //linie.SubItems.Add(nrCantitatea);



                listMeniuri.Items.Add(linie);

            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {




        }

        public void afisareDataGrid(DataGridView dataGridView)
        {

            for(int i = 0;i < meniuri.Count;i++)
            {

                dataGridView.Rows.Add(meniuri[i]);
               
            }



        }


        public List<Meniu> getMeniuri()
        {

            return meniuri;
        }

    }
}
