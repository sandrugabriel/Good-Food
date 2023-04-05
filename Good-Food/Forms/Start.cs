using Good_Food.Forms;
using Good_Food.Panel_uri;
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
       

        public Start()
        {
            InitializeComponent();

            this.Controls.Add(new pnlStart(this));

        }

        public void removePnl(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {

                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);
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
