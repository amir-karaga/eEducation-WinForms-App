
namespace eEducation.UserControls
{
    partial class ucDodajProfesora
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
            this.pbSlikaProf = new System.Windows.Forms.PictureBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMjestoRodjenja = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtProfesija = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDrzavljanstvo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtNacionalnost = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtMjestoPrebivalista = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtZvanje = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.btnDodajProfesora = new System.Windows.Forms.Button();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.cmbSpolovi = new System.Windows.Forms.ComboBox();
            this.cmbStatusProf = new System.Windows.Forms.ComboBox();
            this.ofdOdabirSlike = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaProf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSlikaProf
            // 
            this.pbSlikaProf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlikaProf.Location = new System.Drawing.Point(13, 64);
            this.pbSlikaProf.Name = "pbSlikaProf";
            this.pbSlikaProf.Size = new System.Drawing.Size(248, 280);
            this.pbSlikaProf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlikaProf.TabIndex = 0;
            this.pbSlikaProf.TabStop = false;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIme.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.ForeColor = System.Drawing.SystemColors.Info;
            this.txtIme.Location = new System.Drawing.Point(562, 57);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(300, 20);
            this.txtIme.TabIndex = 1;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.btnDodajSliku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajSliku.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSliku.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodajSliku.Location = new System.Drawing.Point(13, 367);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(248, 31);
            this.btnDodajSliku.TabIndex = 2;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = false;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(372, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime";
            // 
            // pbBack
            // 
            this.pbBack.Image = global::eEducation.Properties.Resources.back_icon3;
            this.pbBack.Location = new System.Drawing.Point(13, 15);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(32, 32);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 15;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(562, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 1);
            this.label2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(562, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 1);
            this.label3.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(372, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Info;
            this.txtEmail.Location = new System.Drawing.Point(562, 127);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(562, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 1);
            this.label5.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(372, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtPrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrezime.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.ForeColor = System.Drawing.SystemColors.Info;
            this.txtPrezime.Location = new System.Drawing.Point(562, 92);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(300, 20);
            this.txtPrezime.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(372, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = "Datum rođenja";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(562, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 1);
            this.label9.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(372, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Mjesto rođenja";
            // 
            // txtMjestoRodjenja
            // 
            this.txtMjestoRodjenja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtMjestoRodjenja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMjestoRodjenja.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMjestoRodjenja.ForeColor = System.Drawing.SystemColors.Info;
            this.txtMjestoRodjenja.Location = new System.Drawing.Point(562, 232);
            this.txtMjestoRodjenja.Name = "txtMjestoRodjenja";
            this.txtMjestoRodjenja.Size = new System.Drawing.Size(300, 20);
            this.txtMjestoRodjenja.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(562, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(300, 1);
            this.label11.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(372, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "Šifra";
            // 
            // txtSifra
            // 
            this.txtSifra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtSifra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifra.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifra.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSifra.Location = new System.Drawing.Point(562, 162);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(300, 20);
            this.txtSifra.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(562, 432);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 1);
            this.label13.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(372, 414);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 19);
            this.label14.TabIndex = 48;
            this.label14.Text = "JMBG";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(562, 467);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(300, 1);
            this.label15.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(372, 449);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 19);
            this.label16.TabIndex = 45;
            this.label16.Text = "Profesija";
            // 
            // txtProfesija
            // 
            this.txtProfesija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtProfesija.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProfesija.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfesija.ForeColor = System.Drawing.SystemColors.Info;
            this.txtProfesija.Location = new System.Drawing.Point(562, 442);
            this.txtProfesija.Name = "txtProfesija";
            this.txtProfesija.Size = new System.Drawing.Size(300, 20);
            this.txtProfesija.TabIndex = 44;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(372, 379);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 19);
            this.label18.TabIndex = 42;
            this.label18.Text = "Spol";
            // 
            // txtDrzavljanstvo
            // 
            this.txtDrzavljanstvo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtDrzavljanstvo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDrzavljanstvo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrzavljanstvo.ForeColor = System.Drawing.SystemColors.Info;
            this.txtDrzavljanstvo.Location = new System.Drawing.Point(562, 337);
            this.txtDrzavljanstvo.Name = "txtDrzavljanstvo";
            this.txtDrzavljanstvo.Size = new System.Drawing.Size(300, 20);
            this.txtDrzavljanstvo.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(562, 327);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(300, 1);
            this.label19.TabIndex = 40;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(372, 309);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 19);
            this.label20.TabIndex = 39;
            this.label20.Text = "Nacionalnost";
            // 
            // txtNacionalnost
            // 
            this.txtNacionalnost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtNacionalnost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNacionalnost.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalnost.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNacionalnost.Location = new System.Drawing.Point(562, 302);
            this.txtNacionalnost.Name = "txtNacionalnost";
            this.txtNacionalnost.Size = new System.Drawing.Size(300, 20);
            this.txtNacionalnost.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(562, 362);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(300, 1);
            this.label21.TabIndex = 37;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(372, 344);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 19);
            this.label22.TabIndex = 36;
            this.label22.Text = "Državljanstvo";
            // 
            // txtJMBG
            // 
            this.txtJMBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtJMBG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJMBG.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJMBG.ForeColor = System.Drawing.SystemColors.Info;
            this.txtJMBG.Location = new System.Drawing.Point(562, 407);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(300, 20);
            this.txtJMBG.TabIndex = 35;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(562, 292);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(300, 1);
            this.label23.TabIndex = 34;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Location = new System.Drawing.Point(372, 274);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(141, 19);
            this.label24.TabIndex = 33;
            this.label24.Text = "Mjesto prebivališta";
            // 
            // txtMjestoPrebivalista
            // 
            this.txtMjestoPrebivalista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtMjestoPrebivalista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMjestoPrebivalista.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMjestoPrebivalista.ForeColor = System.Drawing.SystemColors.Info;
            this.txtMjestoPrebivalista.Location = new System.Drawing.Point(562, 267);
            this.txtMjestoPrebivalista.Name = "txtMjestoPrebivalista";
            this.txtMjestoPrebivalista.Size = new System.Drawing.Size(300, 20);
            this.txtMjestoPrebivalista.TabIndex = 32;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(562, 502);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(300, 1);
            this.label25.TabIndex = 52;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label26.Location = new System.Drawing.Point(372, 484);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 19);
            this.label26.TabIndex = 51;
            this.label26.Text = "Zvanje";
            // 
            // txtZvanje
            // 
            this.txtZvanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtZvanje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZvanje.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZvanje.ForeColor = System.Drawing.SystemColors.Info;
            this.txtZvanje.Location = new System.Drawing.Point(562, 477);
            this.txtZvanje.Name = "txtZvanje";
            this.txtZvanje.Size = new System.Drawing.Size(300, 20);
            this.txtZvanje.TabIndex = 50;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label28.Location = new System.Drawing.Point(372, 520);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(54, 19);
            this.label28.TabIndex = 54;
            this.label28.Text = "Status";
            // 
            // btnDodajProfesora
            // 
            this.btnDodajProfesora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.btnDodajProfesora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajProfesora.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProfesora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodajProfesora.Location = new System.Drawing.Point(562, 576);
            this.btnDodajProfesora.Name = "btnDodajProfesora";
            this.btnDodajProfesora.Size = new System.Drawing.Size(300, 31);
            this.btnDodajProfesora.TabIndex = 56;
            this.btnDodajProfesora.Text = "Dodaj profesora";
            this.btnDodajProfesora.UseVisualStyleBackColor = false;
            this.btnDodajProfesora.Click += new System.EventHandler(this.btnDodajProfesora_Click);
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumRodjenja.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dtpDatumRodjenja.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dtpDatumRodjenja.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(562, 199);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(300, 27);
            this.dtpDatumRodjenja.TabIndex = 57;
            // 
            // cmbSpolovi
            // 
            this.cmbSpolovi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbSpolovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSpolovi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpolovi.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbSpolovi.FormattingEnabled = true;
            this.cmbSpolovi.Location = new System.Drawing.Point(562, 372);
            this.cmbSpolovi.Name = "cmbSpolovi";
            this.cmbSpolovi.Size = new System.Drawing.Size(300, 27);
            this.cmbSpolovi.TabIndex = 58;
            // 
            // cmbStatusProf
            // 
            this.cmbStatusProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbStatusProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatusProf.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatusProf.ForeColor = System.Drawing.Color.White;
            this.cmbStatusProf.FormattingEnabled = true;
            this.cmbStatusProf.Items.AddRange(new object[] {
            "Redovni profesor",
            "Vanredni profesor"});
            this.cmbStatusProf.Location = new System.Drawing.Point(562, 512);
            this.cmbStatusProf.Name = "cmbStatusProf";
            this.cmbStatusProf.Size = new System.Drawing.Size(300, 27);
            this.cmbStatusProf.TabIndex = 59;
            // 
            // ofdOdabirSlike
            // 
            this.ofdOdabirSlike.FileName = "openFileDialog1";
            // 
            // ucDodajProfesora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.cmbStatusProf);
            this.Controls.Add(this.cmbSpolovi);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.btnDodajProfesora);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtZvanje);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtProfesija);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtDrzavljanstvo);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtNacionalnost);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtMjestoPrebivalista);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMjestoRodjenja);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.pbSlikaProf);
            this.Name = "ucDodajProfesora";
            this.Size = new System.Drawing.Size(920, 635);
            this.Load += new System.EventHandler(this.ucDodajProfesora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaProf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSlikaProf;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMjestoRodjenja;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtProfesija;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDrzavljanstvo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtNacionalnost;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtMjestoPrebivalista;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtZvanje;
        private System.Windows.Forms.Button btnDodajProfesora;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.ComboBox cmbSpolovi;
        private System.Windows.Forms.ComboBox cmbStatusProf;
        private System.Windows.Forms.OpenFileDialog ofdOdabirSlike;
    }
}
