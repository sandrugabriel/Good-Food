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
            controllerMeniu.createDataGrid(dataGridView);
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
