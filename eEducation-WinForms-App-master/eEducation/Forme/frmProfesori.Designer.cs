
namespace eEducation.Forme
{
    partial class frmProfesori
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
            this.dgvProfesori = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.btnDodajProfesora = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProfesori
            // 
            this.dgvProfesori.AllowUserToAddRows = false;
            this.dgvProfesori.AllowUserToDeleteRows = false;
            this.dgvProfesori.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProfesori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesori.Location = new System.Drawing.Point(12, 109);
            this.dgvProfesori.Name = "dgvProfesori";
            this.dgvProfesori.ReadOnly = true;
            this.dgvProfesori.RowHeadersWidth = 51;
            this.dgvProfesori.RowTemplate.Height = 24;
            this.dgvProfesori.Size = new System.Drawing.Size(776, 395);
            this.dgvProfesori.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretraga : ";
            // 
            // txtPretraga
            // 
            this.txtPretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtPretraga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPretraga.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPretraga.Location = new System.Drawing.Point(105, 61);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(395, 20);
            this.txtPretraga.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 1);
            this.label2.TabIndex = 3;
            // 
            // pbBack
            // 
            this.pbBack.Image = global::eEducation.Properties.Resources.back_icon3;
            this.pbBack.Location = new System.Drawing.Point(16, 12);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(32, 32);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 15;
            this.pbBack.TabStop = false;
            // 
            // btnDodajProfesora
            // 
            this.btnDodajProfesora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.btnDodajProfesora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajProfesora.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProfesora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodajProfesora.Location = new System.Drawing.Point(583, 55);
            this.btnDodajProfesora.Name = "btnDodajProfesora";
            this.btnDodajProfesora.Size = new System.Drawing.Size(205, 30);
            this.btnDodajProfesora.TabIndex = 16;
            this.btnDodajProfesora.Text = "Novi profesor";
            this.btnDodajProfesora.UseVisualStyleBackColor = false;
            // 
            // frmProfesori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(801, 516);
            this.Controls.Add(this.btnDodajProfesora);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProfesori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfesori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmProfesori";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfesori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Button btnDodajProfesora;
    }
}