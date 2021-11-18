
namespace eEducation.Forme
{
    partial class frmProfilProfesor
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
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlSlika = new System.Windows.Forms.Panel();
            this.lblIme = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnPotvrde = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnPostavke = new System.Windows.Forms.Button();
            this.btnLicniPodaci = new System.Windows.Forms.Button();
            this.btnPredmetiOcjene = new System.Windows.Forms.Button();
            this.btnPrisustva = new System.Windows.Forms.Button();
            this.btnIspiti = new System.Windows.Forms.Button();
            this.btnTestovi = new System.Windows.Forms.Button();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.pnlIzbornik.SuspendLayout();
            this.pnlSlika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIzbornik
            // 
            this.pnlIzbornik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlIzbornik.Controls.Add(this.btnPotvrde);
            this.pnlIzbornik.Controls.Add(this.pnlNav);
            this.pnlIzbornik.Controls.Add(this.btnOdjava);
            this.pnlIzbornik.Controls.Add(this.btnPostavke);
            this.pnlIzbornik.Controls.Add(this.btnLicniPodaci);
            this.pnlIzbornik.Controls.Add(this.btnPredmetiOcjene);
            this.pnlIzbornik.Controls.Add(this.btnPrisustva);
            this.pnlIzbornik.Controls.Add(this.btnIspiti);
            this.pnlIzbornik.Controls.Add(this.btnTestovi);
            this.pnlIzbornik.Controls.Add(this.btnPocetna);
            this.pnlIzbornik.Controls.Add(this.pnlSlika);
            this.pnlIzbornik.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzbornik.Location = new System.Drawing.Point(0, 0);
            this.pnlIzbornik.Name = "pnlIzbornik";
            this.pnlIzbornik.Size = new System.Drawing.Size(220, 720);
            this.pnlIzbornik.TabIndex = 1;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 160);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 65);
            this.pnlNav.TabIndex = 4;
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
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblIme.Location = new System.Drawing.Point(44, 137);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(100, 20);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "User name";
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(226, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(920, 717);
            this.pnlMain.TabIndex = 2;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // btnPotvrde
            // 
            this.btnPotvrde.FlatAppearance.BorderSize = 0;
            this.btnPotvrde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrde.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPotvrde.Image = global::eEducation.Properties.Resources.document_scroll_icon1;
            this.btnPotvrde.Location = new System.Drawing.Point(3, 531);
            this.btnPotvrde.Name = "btnPotvrde";
            this.btnPotvrde.Size = new System.Drawing.Size(220, 60);
            this.btnPotvrde.TabIndex = 9;
            this.btnPotvrde.Text = "Potvrde";
            this.btnPotvrde.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPotvrde.UseVisualStyleBackColor = true;
            this.btnPotvrde.Click += new System.EventHandler(this.btnPotvrde_Click);
            this.btnPotvrde.Leave += new System.EventHandler(this.btnPotvrde_Leave);
            // 
            // btnOdjava
            // 
            this.btnOdjava.FlatAppearance.BorderSize = 0;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnOdjava.Image = global::eEducation.Properties.Resources.LogOut;
            this.btnOdjava.Location = new System.Drawing.Point(3, 657);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(220, 60);
            this.btnOdjava.TabIndex = 8;
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
            this.btnPostavke.Image = global::eEducation.Properties.Resources.Settings;
            this.btnPostavke.Location = new System.Drawing.Point(0, 591);
            this.btnPostavke.Name = "btnPostavke";
            this.btnPostavke.Size = new System.Drawing.Size(220, 60);
            this.btnPostavke.TabIndex = 7;
            this.btnPostavke.Text = "Postavke";
            this.btnPostavke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPostavke.UseVisualStyleBackColor = true;
            this.btnPostavke.Click += new System.EventHandler(this.btnPostavke_Click);
            this.btnPostavke.Leave += new System.EventHandler(this.btnPostavke_Leave);
            // 
            // btnLicniPodaci
            // 
            this.btnLicniPodaci.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLicniPodaci.FlatAppearance.BorderSize = 0;
            this.btnLicniPodaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLicniPodaci.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLicniPodaci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLicniPodaci.Image = global::eEducation.Properties.Resources.LicniPodaci2;
            this.btnLicniPodaci.Location = new System.Drawing.Point(0, 465);
            this.btnLicniPodaci.Name = "btnLicniPodaci";
            this.btnLicniPodaci.Size = new System.Drawing.Size(220, 60);
            this.btnLicniPodaci.TabIndex = 6;
            this.btnLicniPodaci.Text = "Lični podaci";
            this.btnLicniPodaci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLicniPodaci.UseVisualStyleBackColor = true;
            this.btnLicniPodaci.Click += new System.EventHandler(this.btnLicniPodaci_Click);
            this.btnLicniPodaci.Leave += new System.EventHandler(this.btnLicniPodaci_Leave);
            // 
            // btnPredmetiOcjene
            // 
            this.btnPredmetiOcjene.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPredmetiOcjene.FlatAppearance.BorderSize = 0;
            this.btnPredmetiOcjene.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPredmetiOcjene.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredmetiOcjene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPredmetiOcjene.Image = global::eEducation.Properties.Resources.result_icon;
            this.btnPredmetiOcjene.Location = new System.Drawing.Point(0, 405);
            this.btnPredmetiOcjene.Name = "btnPredmetiOcjene";
            this.btnPredmetiOcjene.Size = new System.Drawing.Size(220, 60);
            this.btnPredmetiOcjene.TabIndex = 5;
            this.btnPredmetiOcjene.Text = "Rezultati ispita";
            this.btnPredmetiOcjene.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPredmetiOcjene.UseVisualStyleBackColor = true;
            this.btnPredmetiOcjene.Click += new System.EventHandler(this.btnPredmetiOcjene_Click);
            this.btnPredmetiOcjene.Leave += new System.EventHandler(this.btnPredmetiOcjene_Leave);
            // 
            // btnPrisustva
            // 
            this.btnPrisustva.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrisustva.FlatAppearance.BorderSize = 0;
            this.btnPrisustva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrisustva.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrisustva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPrisustva.Image = global::eEducation.Properties.Resources.Prisustvo;
            this.btnPrisustva.Location = new System.Drawing.Point(0, 345);
            this.btnPrisustva.Name = "btnPrisustva";
            this.btnPrisustva.Size = new System.Drawing.Size(220, 60);
            this.btnPrisustva.TabIndex = 4;
            this.btnPrisustva.Text = "Prisustva";
            this.btnPrisustva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrisustva.UseVisualStyleBackColor = true;
            this.btnPrisustva.Click += new System.EventHandler(this.btnPrisustva_Click);
            this.btnPrisustva.Leave += new System.EventHandler(this.btnPrisustva_Leave);
            // 
            // btnIspiti
            // 
            this.btnIspiti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIspiti.FlatAppearance.BorderSize = 0;
            this.btnIspiti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIspiti.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIspiti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnIspiti.Image = global::eEducation.Properties.Resources.Kalendar;
            this.btnIspiti.Location = new System.Drawing.Point(0, 285);
            this.btnIspiti.Name = "btnIspiti";
            this.btnIspiti.Size = new System.Drawing.Size(220, 60);
            this.btnIspiti.TabIndex = 3;
            this.btnIspiti.Text = "Ispiti";
            this.btnIspiti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIspiti.UseVisualStyleBackColor = true;
            this.btnIspiti.Click += new System.EventHandler(this.btnIspiti_Click);
            this.btnIspiti.Leave += new System.EventHandler(this.btnIspiti_Leave);
            // 
            // btnTestovi
            // 
            this.btnTestovi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTestovi.FlatAppearance.BorderSize = 0;
            this.btnTestovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestovi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestovi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTestovi.Image = global::eEducation.Properties.Resources.accept_icon;
            this.btnTestovi.Location = new System.Drawing.Point(0, 225);
            this.btnTestovi.Name = "btnTestovi";
            this.btnTestovi.Size = new System.Drawing.Size(220, 60);
            this.btnTestovi.TabIndex = 2;
            this.btnTestovi.Text = "Testovi";
            this.btnTestovi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTestovi.UseVisualStyleBackColor = true;
            this.btnTestovi.Click += new System.EventHandler(this.btnTestovi_Click);
            this.btnTestovi.Leave += new System.EventHandler(this.btnTestovi_Leave);
            // 
            // btnPocetna
            // 
            this.btnPocetna.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPocetna.FlatAppearance.BorderSize = 0;
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPocetna.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPocetna.Image = global::eEducation.Properties.Resources.blue_home_icon;
            this.btnPocetna.Location = new System.Drawing.Point(0, 160);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(220, 65);
            this.btnPocetna.TabIndex = 1;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPocetna.UseVisualStyleBackColor = true;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            this.btnPocetna.Leave += new System.EventHandler(this.btnPocetna_Leave);
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(60, 20);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(100, 100);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 1;
            this.pbSlika.TabStop = false;
            // 
            // frmProfilProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1150, 720);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlIzbornik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfilProfesor";
            this.Text = "frmProfilProfesor";
            this.pnlIzbornik.ResumeLayout(false);
            this.pnlSlika.ResumeLayout(false);
            this.pnlSlika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIzbornik;
        private System.Windows.Forms.Button btnPotvrde;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnPostavke;
        private System.Windows.Forms.Button btnLicniPodaci;
        private System.Windows.Forms.Button btnPredmetiOcjene;
        private System.Windows.Forms.Button btnPrisustva;
        private System.Windows.Forms.Button btnIspiti;
        private System.Windows.Forms.Button btnTestovi;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Panel pnlSlika;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Panel pnlMain;
    }
}