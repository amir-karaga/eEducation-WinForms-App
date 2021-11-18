using eEducation.Helpers;
using eEducation.MainClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eEducation.Forme
{
    public partial class frmProfilProfesor : Form
    {
        KonekcijaNaBazu baza = eEducationDataBase.Baza;
        public frmProfilProfesor()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
           (
           int nLeftRect,
           int nTopRect,
           int RightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse

           );
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPocetna.Height;
            pnlNav.Top = btnPocetna.Top;
            pnlNav.Left = btnPocetna.Left;
            btnPocetna.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnTestovi_Click(object sender, EventArgs e)
        {

        }

        private void btnIspiti_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnIspiti.Height;
            pnlNav.Top = btnIspiti.Top;
            btnIspiti.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnPrisustva_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPrisustva.Height;
            pnlNav.Top = btnPrisustva.Top;
            btnPrisustva.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnPredmetiOcjene_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPredmetiOcjene.Height;
            pnlNav.Top = btnPredmetiOcjene.Top;
            btnPredmetiOcjene.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnLicniPodaci_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLicniPodaci.Height;
            pnlNav.Top = btnLicniPodaci.Top;
            btnLicniPodaci.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnPotvrde_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPotvrde.Height;
            pnlNav.Top = btnPotvrde.Top;
            btnPotvrde.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnPostavke_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPostavke.Height;
            pnlNav.Top = btnPostavke.Top;
            btnPostavke.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnOdjava.Height;
            pnlNav.Top = btnOdjava.Top;
            btnOdjava.BackColor = Color.FromArgb(46, 51, 73);
            this.Close();
        }

        private void btnPocetna_Leave(object sender, EventArgs e)
        {
            btnPocetna.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnTestovi_Leave(object sender, EventArgs e)
        {
            btnTestovi.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnIspiti_Leave(object sender, EventArgs e)
        {
            btnIspiti.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPrisustva_Leave(object sender, EventArgs e)
        {
            btnPrisustva.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPredmetiOcjene_Leave(object sender, EventArgs e)
        {
            btnPredmetiOcjene.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLicniPodaci_Leave(object sender, EventArgs e)
        {
            btnLicniPodaci.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPotvrde_Leave(object sender, EventArgs e)
        {
            btnPotvrde.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPostavke_Leave(object sender, EventArgs e)
        {
            btnPostavke.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnOdjava_Leave(object sender, EventArgs e)
        {
            btnOdjava.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
