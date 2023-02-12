namespace P01AplikacjaZawodnicy
{
    partial class FrmMiasta
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
            this.lbDane = new System.Windows.Forms.ListBox();
            this.txtNazwaMiasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(12, 12);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(205, 173);
            this.lbDane.TabIndex = 0;
            this.lbDane.SelectedIndexChanged += new System.EventHandler(this.lbDane_SelectedIndexChanged);
            // 
            // txtNazwaMiasta
            // 
            this.txtNazwaMiasta.Location = new System.Drawing.Point(223, 32);
            this.txtNazwaMiasta.Name = "txtNazwaMiasta";
            this.txtNazwaMiasta.Size = new System.Drawing.Size(157, 20);
            this.txtNazwaMiasta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa miasta";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(223, 58);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(50, 38);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(279, 58);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(45, 38);
            this.btnUsun.TabIndex = 4;
            this.btnUsun.Text = "Usun";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(333, 58);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(47, 38);
            this.btnEdytuj.TabIndex = 5;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aktualna pogoda:";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(324, 114);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.ReadOnly = true;
            this.txtTemperatura.Size = new System.Drawing.Size(43, 20);
            this.txtTemperatura.TabIndex = 7;
            // 
            // FrmMiasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 195);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazwaMiasta);
            this.Controls.Add(this.lbDane);
            this.Name = "FrmMiasta";
            this.Text = "FrmMiasta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.TextBox txtNazwaMiasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemperatura;
    }
}