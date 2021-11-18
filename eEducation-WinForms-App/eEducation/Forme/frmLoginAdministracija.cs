using eEducation.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eEducation.Forme
{
    public partial class frmLoginAdministracija : Form
    {
        KonekcijaNaBazu baza = eEducationDataBase.Baza;
        public frmLoginAdministracija()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            foreach (var administrator in baza.Administratori)
            {
                if(txtLozinka.Text==administrator.Sifra && txtEmail.Text==administrator.Email)
                {
                    frmProfilAdministracija profilAdministracija = 
                        new frmProfilAdministracija(administrator);
                    profilAdministracija.ShowDialog();
                }
            }
            
        }

        private void frmLoginAdministracija_Load(object sender, EventArgs e)
        {

            txtEmail.Text = "test";
            txtLozinka.Text = "test";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
            
            txtLozinka.UseSystemPasswordChar = true;
        }

        private void pbEyeIcon_Click(object sender, EventArgs e)
        {
            if(txtLozinka.UseSystemPasswordChar)
            {
                txtLozinka.UseSystemPasswordChar = false;
            }
            else
            {
                txtLozinka.UseSystemPasswordChar = true;
               
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
