namespace WatchMeOut
{
    partial class Form1
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
            this.DodajMilanaMilanovica = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DodajSanjaDjordjevic = new System.Windows.Forms.Button();
            this.DodajAnaKrstic = new System.Windows.Forms.Button();
            this.VratiKorisnike = new System.Windows.Forms.Button();
            this.ObrisiKorisnika = new System.Windows.Forms.Button();
            this.VratiSanjinOmiljeniZanr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DodajMilanaMilanovica
            // 
            this.DodajMilanaMilanovica.Location = new System.Drawing.Point(32, 28);
            this.DodajMilanaMilanovica.Name = "DodajMilanaMilanovica";
            this.DodajMilanaMilanovica.Size = new System.Drawing.Size(158, 23);
            this.DodajMilanaMilanovica.TabIndex = 0;
            this.DodajMilanaMilanovica.Text = "Dodaj Milan Milanovica";
            this.DodajMilanaMilanovica.UseVisualStyleBackColor = true;
            this.DodajMilanaMilanovica.Click += new System.EventHandler(this.DodajMilanaMilanovica_Click);
            // 
            // DodajSanjaDjordjevic
            // 
            this.DodajSanjaDjordjevic.Location = new System.Drawing.Point(32, 57);
            this.DodajSanjaDjordjevic.Name = "DodajSanjaDjordjevic";
            this.DodajSanjaDjordjevic.Size = new System.Drawing.Size(158, 23);
            this.DodajSanjaDjordjevic.TabIndex = 1;
            this.DodajSanjaDjordjevic.Text = "Dodaj Sanja Djordjevic";
            this.DodajSanjaDjordjevic.UseVisualStyleBackColor = true;
            this.DodajSanjaDjordjevic.Click += new System.EventHandler(this.DodajSanjaDjordjevic_Click);
            // 
            // DodajAnaKrstic
            // 
            this.DodajAnaKrstic.Location = new System.Drawing.Point(32, 86);
            this.DodajAnaKrstic.Name = "DodajAnaKrstic";
            this.DodajAnaKrstic.Size = new System.Drawing.Size(158, 23);
            this.DodajAnaKrstic.TabIndex = 2;
            this.DodajAnaKrstic.Text = "Dodaj Ana Krstic";
            this.DodajAnaKrstic.UseVisualStyleBackColor = true;
            this.DodajAnaKrstic.Click += new System.EventHandler(this.DodajAnaKrstic_Click);
            // 
            // VratiKorisnike
            // 
            this.VratiKorisnike.Location = new System.Drawing.Point(215, 28);
            this.VratiKorisnike.Name = "VratiKorisnike";
            this.VratiKorisnike.Size = new System.Drawing.Size(158, 23);
            this.VratiKorisnike.TabIndex = 3;
            this.VratiKorisnike.Text = "Vrati Korisnike";
            this.VratiKorisnike.UseVisualStyleBackColor = true;
            this.VratiKorisnike.Click += new System.EventHandler(this.VratiKorisnike_Click);
            // 
            // ObrisiKorisnika
            // 
            this.ObrisiKorisnika.Location = new System.Drawing.Point(215, 57);
            this.ObrisiKorisnika.Name = "ObrisiKorisnika";
            this.ObrisiKorisnika.Size = new System.Drawing.Size(158, 23);
            this.ObrisiKorisnika.TabIndex = 4;
            this.ObrisiKorisnika.Text = "Obrisi Korisnika";
            this.ObrisiKorisnika.UseVisualStyleBackColor = true;
            this.ObrisiKorisnika.Click += new System.EventHandler(this.ObrisiKorisnika_Click);
            // 
            // VratiSanjinOmiljeniZanr
            // 
            this.VratiSanjinOmiljeniZanr.Location = new System.Drawing.Point(215, 86);
            this.VratiSanjinOmiljeniZanr.Name = "VratiSanjinOmiljeniZanr";
            this.VratiSanjinOmiljeniZanr.Size = new System.Drawing.Size(158, 23);
            this.VratiSanjinOmiljeniZanr.TabIndex = 5;
            this.VratiSanjinOmiljeniZanr.Text = "Vrati Sanjin omiljeni zanr";
            this.VratiSanjinOmiljeniZanr.UseVisualStyleBackColor = true;
            this.VratiSanjinOmiljeniZanr.Click += new System.EventHandler(this.VratiSanjinOmiljeniZanr_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 350);
            this.Controls.Add(this.VratiSanjinOmiljeniZanr);
            this.Controls.Add(this.ObrisiKorisnika);
            this.Controls.Add(this.VratiKorisnike);
            this.Controls.Add(this.DodajAnaKrstic);
            this.Controls.Add(this.DodajSanjaDjordjevic);
            this.Controls.Add(this.DodajMilanaMilanovica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DodajMilanaMilanovica;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button DodajSanjaDjordjevic;
        private System.Windows.Forms.Button DodajAnaKrstic;
        private System.Windows.Forms.Button VratiKorisnike;
        private System.Windows.Forms.Button ObrisiKorisnika;
        private System.Windows.Forms.Button VratiSanjinOmiljeniZanr;
    }
}

