using Good_Food.Models;
using System;
using System.Collections.Generic;
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

        public void createDataGrid(DataGridView listMeniuri)
        {



        }


    }
}
