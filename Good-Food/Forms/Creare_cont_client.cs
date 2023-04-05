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
    public partial class Creare_cont_client : Form
    {

        List<string> erori;

        ControllerClient controllerClient;

        public Creare_cont_client()
        {
            InitializeComponent();

            erori = new List<string>();
            controllerClient = new ControllerClient();
        }

        public void eroriVerif()
        {
            erori.Clear();

            if (txtNume.Text.Equals(""))
            {
                erori.Add("Nu ati introdus numele");
            }
            if (txtPrenume.Text.Equals(""))
            {
                erori.Add("Nu ati introdus prenumele");
            }
            if (txtAdresa.Text.Equals(""))
            {
                erori.Add("Nu ati introdus adresa");
            }
            if (txtEmail.Text.Equals("") || controllerClient.verifEmail(txtEmail.Text)==false)
            {
                txtEmail.Text = "";
                txtEmail.Focus();
                erori.Add("Nu ati introdus email");
            }
            
            if (!txtParola.Text.Equals(txtReParola.Text))
            {
                erori.Add("Parola nu se potriveste");
                txtParola.Text = "";
                txtReParola.Text = "";
            }
            bool verif = txtParola.Text.Contains("*");
            if (!verif)
            {
                erori.Add("Nu ati folosit caracterul *");
                txtParola.Text = "";
                txtReParola.Text = "";
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            eroriVerif();

            if (erori.Count > 0)
            {

                for (int i = 0; i < erori.Count; i++)
                {
                    MessageBox.Show(erori[i], "Erori", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                int id = controllerClient.generareId();
                string nume = txtNume.Text;
                string prenume = txtPrenume.Text;
                string adresa = txtAdresa.Text;
                string parola = txtParola.Text;
                string email = txtEmail.Text;

                string textul = id.ToString() + ";" + parola + ";" + nume + ";" + prenume + ";" + adresa + ";" + email;
                controllerClient.saveNewClient(textul);
                this.Close();
                Optiuni optiuni = new Optiuni(id);
                optiuni.Show();


            }

                
        }

        private void Creare_cont_client_Load(object sender, EventArgs e)
        {

        }
    }
}
