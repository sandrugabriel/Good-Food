using Good_Food.Controllers;
using Good_Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_Food.Panel_uri
{
    internal class pnlFinal:Panel
    {
        Start form;
        List<Meniu> meniuList;
        DataGridView dataGridView;
        ControllerMeniu controllerMeniu;
        Button btnFinal;
        private int idClien;
        public pnlFinal(Start form1, List<Meniu> list, int idclinet)
        {
            form = form1;
            meniuList = list;
            this.form.MaximumSize = new System.Drawing.Size(692, 565);
            controllerMeniu = new ControllerMeniu();
            idClien = idclinet;
            this.Name = "pnlFinal";
            this.Size = form.Size;

            // dataGridView
            dataGridView = new DataGridView();
            this.Controls.Add(dataGridView);
            this.dataGridView.Location = new System.Drawing.Point(3, 6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(648, 292);
            this.dataGridView.CellClick += new DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.Controls.Add(dataGridView);
            this.Location = new System.Drawing.Point(4, 33);
            this.Name = "Comanda";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(660, 504);
            this.TabIndex = 1;
            this.Text = "Comanda";
            dataGridView.Columns.Add("id_produs", "ID Produs");
            dataGridView.Columns.Add("denumire_produs", "Denumire Produs");
            dataGridView.Columns.Add("descriere", "Descriere");
            dataGridView.Columns.Add("pret", "Pret");
            dataGridView.Columns.Add("kcal", "Kcal");
            dataGridView.Columns.Add("felul", "Felul");
            dataGridView.Columns.Add("cantitate", "Cantitate");
            dataGridView.Columns.Add("elim", "Elimina");
            dataGridView.Columns["id_produs"].ReadOnly = true;
            dataGridView.Columns["denumire_produs"].ReadOnly = true;
            dataGridView.Columns["descriere"].ReadOnly = true;
            dataGridView.Columns["pret"].ReadOnly = true;
            dataGridView.Columns["kcal"].ReadOnly = true;
            dataGridView.Columns["felul"].ReadOnly = true;
            dataGridView.Columns["elim"].HeaderText = "Elimina";
            dataGridView.Columns["cantitate"].DefaultCellStyle.NullValue = "1";

            foreach (var produs in meniuList)
            {
                dataGridView.Rows.Add(produs.getId_produs(), produs.getDenumire_produs(), produs.getDescriere(), produs.getPret(), produs.getkcal(), 1, produs.getFelul(), "Elimina");
            }

            //Btn
            btnFinal = new Button();
            this.Controls.Add(btnFinal);

            this.btnFinal.Location = new System.Drawing.Point(250,350);
            this.btnFinal.Size = new System.Drawing.Size(200, 40);
            this.btnFinal.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11.8F);
            this.btnFinal.Text = "Finalizeaza comanda";
            this.btnFinal.Click += new EventHandler(btnFinal_Click);
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            string textul = "";
            int id_Client = idClien;
            textul = id_Client.ToString() + ";";
            for(int i = 0; i < meniuList.Count; i++)
            {
               
                int id_produs = meniuList[i].getId_produs();
                textul += id_produs.ToString() + ";";
                

            }
            controllerMeniu.saveComanda(textul);

            this.form.removePnl("pnlFinal");
            MessageBox.Show("A-ti finalizat comanda!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.form.Controls.Add(new pnlStart(form));

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView.Columns["elim"].Index && e.RowIndex >= 0)
            {
                int idProdus = (int)dataGridView.Rows[e.RowIndex].Cells["id_produs"].Value;

                for (int i = 0; i < meniuList.Count; i++)
                {
                    if (meniuList[i].getId_produs() == idProdus)
                    {
                        meniuList.RemoveAt(i);
                        break;
                    }
                }

                dataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }

    }
}
