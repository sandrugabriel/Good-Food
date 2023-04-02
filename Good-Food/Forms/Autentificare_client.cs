using Good_Food.Controllers;
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
    public partial class Autentificare_client : Form
    {
        ControllerClient controllerClient;

        public Autentificare_client()
        {
            InitializeComponent();

            controllerClient = new ControllerClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(controllerClient.verifAut(txtEmail.Text,txtParola.Text))
            {
                this.Close();
                int id= controllerClient.idByEmaiParo(txtEmail.Text, txtParola.Text);
                Optiuni optiuni = new Optiuni(id);
                optiuni.Show();
            }
            else
            {

                MessageBox.Show("Eroare autentificare!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtParola.Text = "";
            }
        }
    }
}
