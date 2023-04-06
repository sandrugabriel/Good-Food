using Good_Food.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_Food.Panel_uri
{
    internal class pnlLogin:Panel
    {

        Start form;

        TextBox txtParola;
        TextBox txtEmail;
        Label label4;
        Label label2;
        Label label1;
        Button button1;

        ControllerClient controllerClient;

        public pnlLogin(Start form1)
        {
            controllerClient = new ControllerClient();
            form = form1;
            this.form.Size = new System.Drawing.Size(500, 430);
            this.Name = "pnlLogin";
            this.Size = this.form.Size;

            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();

            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);


            // txtParola
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.txtParola.Location = new System.Drawing.Point(224, 249);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(204, 31);
            this.txtParola.TabIndex = 14;
            this.txtParola.UseSystemPasswordChar = true;

            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.txtEmail.Location = new System.Drawing.Point(224, 191);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 31);
            this.txtEmail.TabIndex = 13;

            // label4
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.label4.Location = new System.Drawing.Point(61, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Parola";

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.label2.Location = new System.Drawing.Point(61, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email";

            // label1
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 36F);
            this.label1.Location = new System.Drawing.Point(88, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 78);
            this.label1.TabIndex = 10;
            this.label1.Text = "Good Food";

            // button1
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.button1.Location = new System.Drawing.Point(177, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 46);
            this.button1.Text = "Intra";
            this.button1.Click += new System.EventHandler(this.button1_Click);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (controllerClient.verifAut(txtEmail.Text, txtParola.Text))
            {
                this.form.removePnl("pnlLogin");
                int id = controllerClient.idByEmaiParo(txtEmail.Text, txtParola.Text);
                this.form.Controls.Add(new pnlOptiuni(id, this.form));
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
