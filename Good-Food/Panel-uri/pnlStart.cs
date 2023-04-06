using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_Food.Panel_uri
{
    internal class pnlStart:Panel
    {

        private Button btnInregistrare;
        private Button btnAutengi;
        private Label lblSlagan;
        private Label lblName;

        Start form;

        public pnlStart(Start form1)
        {
            form = form1;
            this.Name = "pnlStart";
            this.Size = new System.Drawing.Size(form.Size.Width,form.Size.Height);
            this.Location = new Point(0, 0);

            //lblSlagan
            lblSlagan = new Label();
            this.Controls.Add(lblSlagan);
            this.lblSlagan.Location = new Point(44, 66);
            this.lblSlagan.Font = new Font("Microsoft YaHei UI Light", 10);
            this.lblSlagan.Text = "Meniuri diverse caracterizate prin transparenta si excelenta!";
            this.lblSlagan.AutoSize = true;
            this.lblSlagan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;

            //lblName
            lblName = new Label();
            this.Controls.Add(lblName);
            this.lblName.Location = new Point(100, 110);
            this.lblName.Font = new Font("Microsoft YaHei UI Light", 35);
            this.lblName.Text = "Good Food";
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ActiveCaption;

            Font font = new Font("Microsoft YaHei UI Light", 12);

            //Buton Inregistrare
            btnInregistrare = new Button();
            this.Controls.Add(btnInregistrare);

            this.btnInregistrare.Location = new Point(130, 300);
            this.btnInregistrare.Font = font;
            this.btnInregistrare.Size = new Size(167, 66);
            this.btnInregistrare.Text = "Inregistrare";
            this.btnInregistrare.Click += new EventHandler(btnInreg_Click);

            //Buton Autengificare
            btnAutengi = new Button();
            this.Controls.Add(btnAutengi);

            this.btnAutengi.Location = new Point(130, 220);
            this.btnAutengi.Font = font;
            this.btnAutengi.Size = new Size(167, 66);
            this.btnAutengi.Text = "Autentificare";
            this.btnAutengi.Click += new EventHandler(btnAute_Click);

        }

        private void btnInreg_Click(object sender, EventArgs e)
        {
            this.form.removePnl("pnlStart");
            this.form.Controls.Add(new pnlSignUp(form));
            this.form.Size = new System.Drawing.Size(692, 565);
            this.form.MaximumSize = new System.Drawing.Size(692, 565);
        }

        private void btnAute_Click(object sender, EventArgs e)
        {
            this.form.removePnl("pnlStart");
            this.form.Controls.Add(new pnlLogin(form));
            this.form.Size = new System.Drawing.Size(692, 565);
            this.form.MaximumSize = new System.Drawing.Size(692, 565);

        }


    }
}
