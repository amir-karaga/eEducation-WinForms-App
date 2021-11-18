
namespace eEducation.UserControls
{
    partial class ucDodajPredmet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbGodinaStudija = new System.Windows.Forms.ComboBox();
            this.cmbProfesori = new System.Windows.Forms.ComboBox();
            this.btnDodajPredmet = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtNazivPredmeta = new System.Windows.Forms.TextBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.txtECTS = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGodinaStudija
            // 
            this.cmbGodinaStudija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbGodinaStudija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGodinaStudija.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGodinaStudija.ForeColor = System.Drawing.Color.White;
            this.cmbGodinaStudija.FormattingEnabled = true;
            this.cmbGodinaStudija.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbGodinaStudija.Location = new System.Drawing.Point(233, 283);
            this.cmbGodinaStudija.Name = "cmbGodinaStudija";
            this.cmbGodinaStudija.Size = new System.Drawing.Size(300, 27);
            this.cmbGodinaStudija.TabIndex = 79;
            // 
            // cmbProfesori
            // 
            this.cmbProfesori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbProfesori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProfesori.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfesori.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbProfesori.FormattingEnabled = true;
            this.cmbProfesori.Location = new System.Drawing.Point(233, 178);
            this.cmbProfesori.Name = "cmbProfesori";
            this.cmbProfesori.Size = new System.Drawing.Size(300, 27);
            this.cmbProfesori.TabIndex = 78;
            // 
            // btnDodajPredmet
            // 
            this.btnDodajPredmet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.btnDodajPredmet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajPredmet.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPredmet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodajPredmet.Location = new System.Drawing.Point(233, 331);
            this.btnDodajPredmet.Name = "btnDodajPredmet";
            this.btnDodajPredmet.Size = new System.Drawing.Size(300, 31);
            this.btnDodajPredmet.TabIndex = 77;
            this.btnDodajPredmet.Text = "Dodaj predmet";
            this.btnDodajPredmet.UseVisualStyleBackColor = false;
            this.btnDodajPredmet.Click += new System.EventHandler(this.btnDodajPredmet_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label28.Location = new System.Drawing.Point(43, 285);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(112, 19);
            this.label28.TabIndex = 76;
            this.label28.Text = "Godina studija";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(233, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 1);
            this.label13.TabIndex = 72;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(43, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 19);
            this.label14.TabIndex = 71;
            this.label14.Text = "ECTS";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(43, 185);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 19);
            this.label18.TabIndex = 67;
            this.label18.Text = "Profesor";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(233, 148);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(300, 1);
            this.label19.TabIndex = 65;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(43, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(121, 19);
            this.label20.TabIndex = 64;
            this.label20.Text = "Naziv predmeta";
            // 
            // txtNazivPredmeta
            // 
            this.txtNazivPredmeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtNazivPredmeta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNazivPredmeta.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivPredmeta.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNazivPredmeta.Location = new System.Drawing.Point(233, 125);
            this.txtNazivPredmeta.Name = "txtNazivPredmeta";
            this.txtNazivPredmeta.Size = new System.Drawing.Size(300, 20);
            this.txtNazivPredmeta.TabIndex = 63;
            // 
            // pbBack
            // 
            this.pbBack.Image = global::eEducation.Properties.Resources.back_icon3;
            this.pbBack.Location = new System.Drawing.Point(18, 20);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(32, 32);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 80;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // txtECTS
            // 
            this.txtECTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtECTS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtECTS.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtECTS.ForeColor = System.Drawing.SystemColors.Info;
            this.txtECTS.Location = new System.Drawing.Point(233, 230);
            this.txtECTS.Name = "txtECTS";
            this.txtECTS.Size = new System.Drawing.Size(300, 20);
            this.txtECTS.TabIndex = 81;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // ucDodajPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.txtECTS);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.cmbGodinaStudija);
            this.Controls.Add(this.cmbProfesori);
            this.Controls.Add(this.btnDodajPredmet);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtNazivPredmeta);
            this.Name = "ucDodajPredmet";
            this.Size = new System.Drawing.Size(600, 500);
            this.Load += new System.EventHandler(this.ucDodajPredmet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGodinaStudija;
        private System.Windows.Forms.ComboBox cmbProfesori;
        private System.Windows.Forms.Button btnDodajPredmet;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtNazivPredmeta;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.TextBox txtECTS;
        private System.Windows.Forms.ErrorProvider err;
    }
}
