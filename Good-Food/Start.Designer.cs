namespace Good_Food
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAute = new System.Windows.Forms.Button();
            this.btnInreg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Good Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meniuri diverse caracterizate prin transparenta si excelenta!";
            // 
            // btnAute
            // 
            this.btnAute.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAute.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAute.Location = new System.Drawing.Point(212, 280);
            this.btnAute.Name = "btnAute";
            this.btnAute.Size = new System.Drawing.Size(167, 66);
            this.btnAute.TabIndex = 2;
            this.btnAute.Text = "Autentificare";
            this.btnAute.UseVisualStyleBackColor = false;
            // 
            // btnInreg
            // 
            this.btnInreg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInreg.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInreg.Location = new System.Drawing.Point(212, 375);
            this.btnInreg.Name = "btnInreg";
            this.btnInreg.Size = new System.Drawing.Size(167, 66);
            this.btnInreg.TabIndex = 3;
            this.btnInreg.Text = "Inregistrare";
            this.btnInreg.UseVisualStyleBackColor = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(621, 494);
            this.Controls.Add(this.btnInreg);
            this.Controls.Add(this.btnAute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAute;
        private System.Windows.Forms.Button btnInreg;
    }
}

