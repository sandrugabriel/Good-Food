using Good_Food.Controllers;
using Good_Food.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_Food.Forms
{
    public partial class Optiuni : Form
    {

        private int id_Client;

        ControllerMeniu controllerMeniu;

        public Optiuni(int id)
        {
            InitializeComponent();

            id_Client = id;
            
            controllerMeniu = new ControllerMeniu();
            // controllerMeniu.afisareDataGrid(dataGridView);
            afisareDataGrid();
        }

        private void afisareDataGrid()
        {

            string[] row0 = { "11/233/23", "23", "Reasik 9", "Beatles", "Thecijfif" };
            string[] row1 = { "12/233/24", "6", "Asdf3e", "Tresfr", "ASdf" };
            string[] row2 = { "99/23f/234", "235", "9", "Btles", "Thef" };
            string[] row3 = { "11/3/3", "233", "R 9", "les", "WErgrvimd" };
            string[] row4 = { "1/233/2", "3", "ik 9", "Bees", "fif" };
            string[] row5 = { "151/253/53", "5", "Rk 9", "Beles", "The" };
            string[] row6 = { "71/27/27", "45", "R9", "Be", "jfif" };

            dataGridView.Rows.Add(row0);
            dataGridView.Rows.Add(row1);
            dataGridView.Rows.Add(row2);
            dataGridView.Rows.Add(row3);
            dataGridView.Rows.Add(row4);
            dataGridView.Rows.Add(row5);
            dataGridView.Rows.Add(row6);

            dataGridView.Columns[0].DisplayIndex = 3;
            dataGridView.Columns[1].DisplayIndex = 4;
            dataGridView.Columns[2].DisplayIndex = 0;
            dataGridView.Columns[3].DisplayIndex = 1;
            dataGridView.Columns[4].DisplayIndex = 2;

        }

        private void Optiuni_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suma = ((int)numericUpDown1.Value) + ((int)numericUpDown2.Value) + ((int)numericUpDown3.Value);

            if (suma < 250) txtKcal.Text = "1800";
            if (250 <= suma && suma <= 275) txtKcal.Text = "2200";
            if(suma>275) txtKcal.Text = "2500";

        }
    }
}
