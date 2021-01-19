
namespace WatchMeOut
{
    partial class BrisanjeKorisnikaForm
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
            this.lblSifraZaBrisanjeKorisnika = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSifraZaBrisanjeKorisnika
            // 
            this.lblSifraZaBrisanjeKorisnika.AutoSize = true;
            this.lblSifraZaBrisanjeKorisnika.Location = new System.Drawing.Point(49, 40);
            this.lblSifraZaBrisanjeKorisnika.Name = "lblSifraZaBrisanjeKorisnika";
            this.lblSifraZaBrisanjeKorisnika.Size = new System.Drawing.Size(222, 13);
            this.lblSifraZaBrisanjeKorisnika.TabIndex = 0;
            this.lblSifraZaBrisanjeKorisnika.Text = "Unesite sifru da biste izvrsili brisanje korisnika:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(99, 82);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(100, 20);
            this.txtSifra.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(112, 131);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // BrisanjeKorisnikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 294);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.lblSifraZaBrisanjeKorisnika);
            this.Name = "BrisanjeKorisnikaForm";
            this.Text = "BrisanjeKorisnikaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSifraZaBrisanjeKorisnika;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Button btnOK;
    }
}