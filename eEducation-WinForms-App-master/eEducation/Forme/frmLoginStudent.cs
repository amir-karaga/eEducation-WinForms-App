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
    public partial class frmLoginStudent : Form
    {
        KonekcijaNaBazu baza = eEducationDataBase.Baza;
        public frmLoginStudent()
        {
            InitializeComponent();
        }

        private void frmLoginStudent_Load(object sender, EventArgs e)
        {

        }

        private void txtBrIndeksa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            foreach (var std in baza.Studenti)
            {
                //if(std.BrojIndeksa==txtBrIndeksa.Text && std.Sifra==txtLozinka.Text)
                //{
                    frmProfilStudent profilStudent = new frmProfilStudent(std);
                    this.Hide();
                    profilStudent.ShowDialog();
                    this.Show();
                //}
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
