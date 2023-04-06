using Good_Food.Controllers;
using Good_Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Good_Food.Panel_uri
{
    internal class pnlOptiuni : Panel
    {
        private int id;

        private List<Meniu> listAdaugaCos;

        TabControl tabControl1;
        TabPage CalculatorKcal;
        TabPage Comanda;
        TabPage grafic;
        TabPage generare;
        Button btnCalc;
        TextBox txtKcal;
        Label label4;
        NumericUpDown numericUpDown3;
        NumericUpDown numericUpDown2;
        NumericUpDown numericUpDown1;
        Label label3;
        Label label1;
        Label label2;
        DataGridView dataGridView;
        Start form;
        Label lblTotalPret;
        TextBox txtTotalPret;
        ControllerMeniu controllerMeniu;
        private List<Meniu> meniuList;

        public pnlOptiuni(int id1, Start form1)
        {
            listAdaugaCos = new List<Meniu>();  
            id = id1;
            form = form1;
            this.form.Size = new System.Drawing.Size(692, 565);
            this.Size = form.Size;
            this.Name = "pnlOptiuni";
            this.Text = "Optiuni";
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            controllerMeniu = new ControllerMeniu();
            meniuList = new List<Meniu>();

            this.tabControl1 = new TabControl();
            this.CalculatorKcal = new TabPage();
            this.Comanda = new TabPage();
            this.grafic = new TabPage();
            this.generare = new TabPage();
            this.label2 = new Label();
            this.label1 = new Label();
            this.label3 = new Label();
            this.numericUpDown1 = new NumericUpDown();
            this.numericUpDown2 = new NumericUpDown();
            this.numericUpDown3 = new NumericUpDown();
            this.label4 = new Label();
            this.txtKcal = new TextBox();
            this.btnCalc = new Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblTotalPret = new Label();
            this.txtTotalPret = new TextBox();
            this.Controls.Add(tabControl1);

            // tabControl1
            this.tabControl1.Controls.Add(this.CalculatorKcal);
            this.tabControl1.Controls.Add(this.Comanda);
            this.tabControl1.Controls.Add(this.generare);
            this.tabControl1.Controls.Add(this.grafic);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 541);
            this.tabControl1.TabIndex = 0;

            // CalculatorKcal
            this.CalculatorKcal.Controls.Add(this.btnCalc);
            this.CalculatorKcal.Controls.Add(this.txtKcal);
            this.CalculatorKcal.Controls.Add(this.label4);
            this.CalculatorKcal.Controls.Add(this.numericUpDown3);
            this.CalculatorKcal.Controls.Add(this.numericUpDown2);
            this.CalculatorKcal.Controls.Add(this.numericUpDown1);
            this.CalculatorKcal.Controls.Add(this.label3);
            this.CalculatorKcal.Controls.Add(this.label1);
            this.CalculatorKcal.Controls.Add(this.label2);
            this.CalculatorKcal.Location = new System.Drawing.Point(4, 33);
            this.CalculatorKcal.Name = "CalculatorKcal";
            this.CalculatorKcal.Padding = new System.Windows.Forms.Padding(3);
            this.CalculatorKcal.Size = new System.Drawing.Size(660, 504);
            this.CalculatorKcal.TabIndex = 0;
            this.CalculatorKcal.Text = "CalculatorKcal";
            this.CalculatorKcal.UseVisualStyleBackColor = true;

            // dataGridView
            this.dataGridView.Location = new System.Drawing.Point(3, 6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(648, 292);
            this.dataGridView.CellClick += new DataGridViewCellEventHandler(this.dataGridView_CellClick);

            // Comanda
            this.Comanda.Controls.Add(dataGridView);
            this.Comanda.Controls.Add(lblTotalPret);
            this.Comanda.Controls.Add(txtTotalPret);
            this.lblTotalPret.Location = new System.Drawing.Point(3,350);
            this.txtTotalPret.Location = new System.Drawing.Point(100, 350);
            this.txtTotalPret.ReadOnly = true;
            this.txtTotalPret.Text = "0";
            this.lblTotalPret.Text = "Total pret:";
            this.Comanda.Location = new System.Drawing.Point(4, 33);
            this.Comanda.Name = "Comanda";
            this.Comanda.Padding = new System.Windows.Forms.Padding(3);
            this.Comanda.Size = new System.Drawing.Size(660, 504);
            this.Comanda.TabIndex = 1;
            this.Comanda.Text = "Comanda";
            this.Comanda.UseVisualStyleBackColor = true;
            dataGridView.Columns.Add("id_produs", "ID Produs");
            dataGridView.Columns.Add("denumire_produs", "Denumire Produs");
            dataGridView.Columns.Add("descriere", "Descriere");
            dataGridView.Columns.Add("pret", "Pret");
            dataGridView.Columns.Add("kcal", "Kcal");
            dataGridView.Columns.Add("felul", "Felul");
            dataGridView.Columns.Add("cantitate", "Cantitate");
            dataGridView.Columns.Add("adauga", "Adauga");
            dataGridView.Columns["id_produs"].ReadOnly = true;
            dataGridView.Columns["denumire_produs"].ReadOnly = true;
            dataGridView.Columns["descriere"].ReadOnly = true;
            dataGridView.Columns["pret"].ReadOnly = true;
            dataGridView.Columns["kcal"].ReadOnly = true;
            dataGridView.Columns["felul"].ReadOnly = true;
            dataGridView.Columns["adauga"].HeaderText = "Adauga";
            dataGridView.Columns["cantitate"].DefaultCellStyle.NullValue = "1";
            
            meniuList = controllerMeniu.getMeniuri();
            foreach (var produs in meniuList)
            {
                dataGridView.Rows.Add(produs.getId_produs(), produs.getDenumire_produs(), produs.getDescriere(), produs.getPret(), produs.getkcal(),1, produs.getFelul(),"Adauga");
            }


            // generare
            this.generare.Location = new System.Drawing.Point(4, 25);
            this.generare.Name = "generare";
            this.generare.Size = new System.Drawing.Size(602, 447);
            this.generare.TabIndex = 2;
            this.generare.Text = "Generare Meniu";
            this.generare.UseVisualStyleBackColor = true;
             
            // grafic
            this.grafic.Location = new System.Drawing.Point(4, 25);
            this.grafic.Name = "grafic";
            this.grafic.Size = new System.Drawing.Size(602, 447);
            this.grafic.TabIndex = 3;
            this.grafic.Text = "Grafic Kcal";
            this.grafic.UseVisualStyleBackColor = true;
             
            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F);
            this.label2.Location = new System.Drawing.Point(64, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Varsta(ani)";
             
            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F);
            this.label1.Location = new System.Drawing.Point(64, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Inaltimea(cm)";
             
            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F);
            this.label3.Location = new System.Drawing.Point(64, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 39);
            this.label3.TabIndex = 20;
            this.label3.Text = "Greutatea(kg)";
             
            // numericUpDown1
            this.numericUpDown1.Location = new System.Drawing.Point(381, 65);
            this.numericUpDown1.Maximum = 9999;
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(125, 31);
            this.numericUpDown1.TabIndex = 23;
             
            // numericUpDown2
            this.numericUpDown2.Location = new System.Drawing.Point(381, 219);
            this.numericUpDown2.Maximum = 9999;
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(125, 31);
            this.numericUpDown2.TabIndex = 24;
             
            // numericUpDown3
            this.numericUpDown3.Location = new System.Drawing.Point(381, 140);
            this.numericUpDown3.Maximum = 9999;
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(125, 31);
            this.numericUpDown3.TabIndex = 25;
             
            // label4
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F);
            this.label4.Location = new System.Drawing.Point(54, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 39);
            this.label4.TabIndex = 26;
            this.label4.Text = "Necesar zilnic:";
             
            // txtKcal
            this.txtKcal.Location = new System.Drawing.Point(339, 327);
            this.txtKcal.Name = "txtKcal";
            this.txtKcal.ReadOnly = true;
            this.txtKcal.Size = new System.Drawing.Size(167, 31);
            this.txtKcal.TabIndex = 27;
             
            // BtnClac
            this.btnCalc.Location = new System.Drawing.Point(208, 410);
            this.btnCalc.Name = "button1";
            this.btnCalc.Size = new System.Drawing.Size(159, 51);
            this.btnCalc.TabIndex = 28;
            this.btnCalc.Text = "Calculeaza";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnClac_Click);




        }


        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificăm dacă butonul "Adauga" a fost apăsat
            if (e.ColumnIndex == dataGridView.Columns["adauga"].Index && e.RowIndex >= 0)
            {
                int cantitatea =int.Parse(dataGridView.Rows[e.RowIndex].Cells["cantitate"].Value.ToString());
                int pretul = int.Parse(dataGridView.Rows[e.RowIndex].Cells["pret"].Value.ToString());
                int pretulInitial = int.Parse(txtTotalPret.Text);
                int suma = cantitatea * pretul + pretulInitial;
                txtTotalPret.Text = suma.ToString();
            }
        }
        private void btnClac_Click(object sender, System.EventArgs e)
        {

            int suma = ((int)numericUpDown1.Value) + ((int)numericUpDown2.Value) + ((int)numericUpDown3.Value);

            if (suma < 250) txtKcal.Text = "1800";
            if (250 <= suma && suma <= 275) txtKcal.Text = "2200";
            if (suma > 275) txtKcal.Text = "2500";

        }

    }
}
