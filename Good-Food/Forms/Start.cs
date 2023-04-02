using Good_Food.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_Food
{
    public partial class Start : Form
    {
        private Button btnInregistrare;
        private Button btnAutengi;
        private Label lblSlagan;
        private Label lblName;


        public Start()
        {
            InitializeComponent();


            //lblSlagan
            lblSlagan = new Label();
            this.Controls.Add(lblSlagan);
            this.lblSlagan.Location = new Point( 44, 66);
            this.lblSlagan.Font = new Font("Microsoft YaHei UI Light",10);
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

            //



        }

        private void btnInreg_Click(object sender, EventArgs e)
        {
            
            Creare_cont_client form = new Creare_cont_client();
            form.Show();
        }

        private void btnAute_Click(object sender, EventArgs e)
        {
            Autentificare_client form = new Autentificare_client();
            form.Show();
        }
    }
}
