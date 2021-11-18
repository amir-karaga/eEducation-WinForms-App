
namespace eEducation.Forme
{
    partial class frmProfilAdministracija
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
            this.pnlIzbornik = new System.Windows.Forms.Panel();
            this.btnPredmeti = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnPostavke = new System.Windows.Forms.Button();
            this.btnPotvrde = new System.Windows.Forms.Button();
            this.btnStudenti = new System.Windows.Forms.Button();
            this.btnProfesori = new System.Windows.Forms.Button();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.pnlSlika = new System.Windows.Forms.Panel();
            this.lblIme = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlIzbornik.SuspendLayout();
            this.pnlSlika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIzbornik
            // 
            this.pnlIzbornik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlIzbornik.Controls.Add(this.btnPredmeti);
            this.pnlIzbornik.Controls.Add(this.pnlNav);
            this.pnlIzbornik.Controls.Add(this.btnOdjava);
            this.pnlIzbornik.Controls.Add(this.btnPostavke);
            this.pnlIzbornik.Controls.Add(this.btnPotvrde);
            this.pnlIzbornik.Controls.Add(this.btnStudenti);
            this.pnlIzbornik.Controls.Add(this.btnProfesori);
            this.pnlIzbornik.Controls.Add(this.btnPocetna);
            this.pnlIzbornik.Controls.Add(this.pnlSlika);
            this.pnlIzbornik.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzbornik.Location = new System.Drawing.Point(0, 0);
            this.pnlIzbornik.Name = "pnlIzbornik";
            this.pnlIzbornik.Size = new System.Drawing.Size(220, 635);
            this.pnlIzbornik.TabIndex = 0;
            // 
            // btnPredmeti
            // 
            this.btnPredmeti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPredmeti.FlatAppearance.BorderSize = 0;
            this.btnPredmeti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPredmeti.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredmeti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPredmeti.Image = global::eEducation.Properties.Resources.Books_icon1;
            this.btnPredmeti.Location = new System.Drawing.Point(0, 355);
            this.btnPredmeti.Name = "btnPredmeti";
            this.btnPredmeti.Size = new System.Drawing.Size(220, 65);
            this.btnPredmeti.TabIndex = 8;
            this.btnPredmeti.Text = "Predmeti";
            this.btnPredmeti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPredmeti.UseVisualStyleBackColor = true;
            this.btnPredmeti.Click += new System.EventHandler(this.btnPredmeti_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 160);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 65);
            this.pnlNav.TabIndex = 0;
            // 
            // btnOdjava
            // 
            this.btnOdjava.FlatAppearance.BorderSize = 0;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnOdjava.Image = global::eEducation.Properties.Resources.LogOut1;
            this.btnOdjava.Location = new System.Drawing.Point(0, 570);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(220, 65);
            this.btnOdjava.TabIndex = 7;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            this.btnOdjava.Leave += new System.EventHandler(this.btnOdjava_Leave);
            // 
            // btnPostavke
            // 
            this.btnPostavke.FlatAppearance.BorderSize = 0;
            this.btnPostavke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostavke.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostavke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPostavke.Image = global::eEducation.Properties.Resources.Settings1;
            this.btnPostavke.Location = new System.Drawing.Point(0, 499);
            this.btnPostavke.Name = "btnPostavke";
            this.btnPostavke.Size = new System.Drawing.Size(220, 65);
            this.btnPostavke.TabIndex = 6;
            this.btnPostavke.Text = "Postavke";
            this.btnPostavke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPostavke.UseVisualStyleBackColor = true;
            this.btnPostavke.Click += new System.EventHandler(this.btnPostavke_Click);
            this.btnPostavke.Leave += new System.EventHandler(this.btnPostavke_Leave);
            // 
            // btnPotvrde
            // 
            this.btnPotvrde.FlatAppearance.BorderSize = 0;
            this.btnPotvrde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrde.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPotvrde.Image = global::eEducation.Properties.Resources.document_scroll_icon;
            this.btnPotvrde.Location = new System.Drawing.Point(0, 428);
            this.btnPotvrde.Name = "btnPotvrde";
            this.btnPotvrde.Size = new System.Drawing.Size(220, 65);
            this.btnPotvrde.TabIndex = 5;
            this.btnPotvrde.Text = "Potvrde";
            this.btnPotvrde.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPotvrde.UseVisualStyleBackColor = true;
            this.btnPotvrde.Click += new System.EventHandler(this.btnPotvrde_Click);
            this.btnPotvrde.Leave += new System.EventHandler(this.btnPotvrde_Leave);
            // 
            // btnStudenti
            // 
            this.btnStudenti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudenti.FlatAppearance.BorderSize = 0;
            this.btnStudenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudenti.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudenti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnStudenti.Image = global::eEducation.Properties.Resources.user_student_icon;
            this.btnStudenti.Location = new System.Drawing.Point(0, 290);
            this.btnStudenti.Name = "btnStudenti";
            this.btnStudenti.Size = new System.Drawing.Size(220, 65);
            this.btnStudenti.TabIndex = 4;
            this.btnStudenti.Text = "Studenti";
            this.btnStudenti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStudenti.UseVisualStyleBackColor = true;
            this.btnStudenti.Click += new System.EventHandler(this.btnStudenti_Click);
            this.btnStudenti.Leave += new System.EventHandler(this.btnStudenti_Leave);
            // 
            // btnProfesori
            // 
            this.btnProfesori.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfesori.FlatAppearance.BorderSize = 0;
            this.btnProfesori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesori.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnProfesori.Image = global::eEducation.Properties.Resources.users_icon1;
            this.btnProfesori.Location = new System.Drawing.Point(0, 225);
            this.btnProfesori.Name = "btnProfesori";
            this.btnProfesori.Size = new System.Drawing.Size(220, 65);
            this.btnProfesori.TabIndex = 3;
            this.btnProfesori.Text = "Profesori";
            this.btnProfesori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProfesori.UseVisualStyleBackColor = true;
            this.btnProfesori.Click += new System.EventHandler(this.btnProfesori_Click);
            this.btnProfesori.Leave += new System.EventHandler(this.btnProfesori_Leave);
            // 
            // btnPocetna
            // 
            this.btnPocetna.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPocetna.FlatAppearance.BorderSize = 0;
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPocetna.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPocetna.Image = global::eEducation.Properties.Resources.Home1;
            this.btnPocetna.Location = new System.Drawing.Point(0, 160);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(220, 65);
            this.btnPocetna.TabIndex = 2;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPocetna.UseVisualStyleBackColor = true;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            this.btnPocetna.Leave += new System.EventHandler(this.btnPocetna_Leave);
            // 
            // pnlSlika
            // 
            this.pnlSlika.Controls.Add(this.lblIme);
            this.pnlSlika.Controls.Add(this.pbSlika);
            this.pnlSlika.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSlika.Location = new System.Drawing.Point(0, 0);
            this.pnlSlika.Name = "pnlSlika";
            this.pnlSlika.Size = new System.Drawing.Size(220, 160);
            this.pnlSlika.TabIndex = 0;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblIme.Location = new System.Drawing.Point(60, 130);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(95, 19);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "User Name";
            this.lblIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(60, 20);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(100, 100);
            this.pbSlika.TabIndex = 0;
            this.pbSlika.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(226, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(923, 635);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // frmProfilAdministracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1150, 635);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlIzbornik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfilAdministracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfilAdministracija";
            this.Load += new System.EventHandler(this.frmProfilAdministracija_Load);
            this.pnlIzbornik.ResumeLayout(false);
            this.pnlSlika.ResumeLayout(false);
            this.pnlSlika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIzbornik;
        private System.Windows.Forms.Panel pnlSlika;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button btnStudenti;
        private System.Windows.Forms.Button btnProfesori;
        private System.Windows.Forms.Button btnPotvrde;
        private System.Windows.Forms.Button btnPostavke;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnPredmeti;
        private System.Windows.Forms.Panel pnlMain;
    }
}