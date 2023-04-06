using Good_Food.Controllers;
using Good_Food.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_Food.Panel_uri
{
    internal class pnlSignUp:Panel
    {
        List<string> erori;

        Start form;

        Label lblLogo;

        Label lblNume;
        TextBox txtNume;

        Label lblPrenume;
        TextBox txtPrenume;

        Label lblAdresa;
        TextBox txtAdresa;

        Label lblParola;
        TextBox txtParola;

        Label lblReparola;
        TextBox txtReparola;

        Label lblEmail;
        TextBox txtEmail;

        Button btnSignUp;

        ControllerClient controllerClient;

        public pnlSignUp(Start form1)
        {
            form = form1;
            controllerClient = new ControllerClient();
            erori = new List<string>();
            this.form.Size = new System.Drawing.Size(587, 734);
            this.Name = "pnlSignUp";
            this.Size = new System.Drawing.Size(form.Size.Width, form.Size.Height);

            Font font = new Font("Microsoft YaHei UI Light",18);
            
            //logo
            lblLogo = new Label();
            this.Controls.Add(lblLogo);
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 36F, System.Drawing.FontStyle.Regular);
            this.lblLogo.Location = new System.Drawing.Point(104, 79);
            this.lblLogo.Name = "label1";
            this.lblLogo.Size = new System.Drawing.Size(340, 78);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Good Food";

            //Nume
            lblNume = new Label();
            txtNume = new TextBox();
            this.Controls.Add(lblNume);
            this.Controls.Add(txtNume);

            this.lblNume.Location = new System.Drawing.Point(46, 234);
            this.lblNume.AutoSize = true;
            this.lblNume.Font = font;
            this.lblNume.Text = "Nume";
            this.txtNume.Location = new System.Drawing.Point(312, 234);
            this.txtNume.Font = font;
            this.txtNume.Size = new System.Drawing.Size(204, 31);

            //Prenume
            lblPrenume = new Label();
            txtPrenume = new TextBox();
            this.Controls.Add(lblPrenume);
            this.Controls.Add(txtPrenume);

            this.lblPrenume.Location = new System.Drawing.Point(46, 289);
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = font;
            this.lblPrenume.Text = "Prenume";
            this.txtPrenume.Location = new System.Drawing.Point(312, 289);
            this.txtPrenume.Font = font;
            this.txtPrenume.Size = new System.Drawing.Size(204, 31);

            //Adresa
            lblAdresa = new Label();
            txtAdresa = new TextBox();
            this.Controls.Add(lblAdresa);
            this.Controls.Add(txtAdresa);

            this.lblAdresa.Location = new System.Drawing.Point(46, 352);
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = font;
            this.lblAdresa.Text = "Adresa";
            this.txtAdresa.Location = new System.Drawing.Point(312, 352);
            this.txtAdresa.Font = font;
            this.txtAdresa.Size = new System.Drawing.Size(204, 31);

            //Parola
            lblParola = new Label();
            txtParola = new TextBox();
            this.Controls.Add(lblParola);
            this.Controls.Add(txtParola);

            this.lblParola.Location = new System.Drawing.Point(46, 413);
            this.lblParola.AutoSize = true;
            this.lblParola.Font = font;
            this.lblParola.Text = "Parola";
            this.txtParola.Location = new System.Drawing.Point(312, 409);
            this.txtParola.Font = font;
            this.txtParola.Size = new System.Drawing.Size(204, 31);

            //Reparola
            lblReparola = new Label();
            txtReparola = new TextBox();
            this.Controls.Add(lblReparola);
            this.Controls.Add(txtReparola);

            this.lblReparola.Location = new System.Drawing.Point(46, 473);
            this.lblReparola.AutoSize = true;
            this.lblReparola.Font = font;
            this.lblReparola.Text = "Reintroduceti parola";
            this.txtReparola.Location = new System.Drawing.Point(312, 473);
            this.txtReparola.Font = font;
            this.txtReparola.Size = new System.Drawing.Size(204, 31);

            //Email
            lblEmail = new Label();
            txtEmail = new TextBox();
            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);

            this.lblEmail.Location = new System.Drawing.Point(46, 541);
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = font;
            this.lblEmail.Text = "Reintroduceti parola";
            this.txtEmail.Location = new System.Drawing.Point(312, 541);
            this.txtEmail.Font = font;
            this.txtEmail.Size = new System.Drawing.Size(204, 31);

            //Buton SignUp
            btnSignUp = new Button();  
            this.Controls.Add(btnSignUp);

            this.btnSignUp.Location = new System.Drawing.Point(167, 621);
            this.btnSignUp.Name = "button1";
            this.btnSignUp.Font = font;
            this.btnSignUp.Size = new System.Drawing.Size(166, 45);
            this.btnSignUp.TabIndex = 17;
            this.btnSignUp.Text = "Creare cont";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
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
            if (txtEmail.Text.Equals("") || controllerClient.verifEmail(txtEmail.Text) == false)
            {
                txtEmail.Text = "";
                txtEmail.Focus();
                erori.Add("Nu ati introdus email");
            }

            if (!txtParola.Text.Equals(txtReparola.Text))
            {
                erori.Add("Parola nu se potriveste");
                txtParola.Text = "";
                txtReparola.Text = "";
            }
            bool verif = txtParola.Text.Contains("*");
            if (!verif)
            {
                erori.Add("Nu ati folosit caracterul *");
                txtParola.Text = "";
                txtReparola.Text = "";
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
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
                this.form.removePnl("pnlSignUp");
                this.form.Controls.Add(new pnlOptiuni(id,form));

            }


        }



    }
}
