using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using eEducation.UserControls;
using eEducation.MainClasses;
using eEducation.Helpers;

namespace eEducation.Forme
{
    public partial class frmProfilStudent : Form
    {
        public KonekcijaNaBazu baza = eEducationDataBase.Baza;
        Student student;

        

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
        public frmProfilStudent()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));     
        }
        public frmProfilStudent(Student student):this()
        {
            this.student = student;
            pbSlika.Image = ImageHelpers.FromByteToImage(this.student.Slika);
            lblIme.Text = $"{student.Ime} {student.Prezime}";
        }
        private void frmProfilStudent_Load(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(Pocetna.instance))
            {
                Pocetna.ListaObavijesti = baza.Obavijesti.ToList();
                pnlMain.Controls.Add(Pocetna.instance);
                Pocetna.instance.Dock = DockStyle.Fill;
                Pocetna.instance.BringToFront();
            }
            else
            {
                Pocetna.ListaObavijesti = baza.Obavijesti.ToList();
                Pocetna.instance.Ucitaj();
                Pocetna.instance.BringToFront();
            }
        }
        
        private void btnPocetna_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPocetna.Height;
            pnlNav.Top = btnPocetna.Top;
            pnlNav.Left = btnPocetna.Left;
            btnPocetna.BackColor = Color.FromArgb(46, 51, 73);
            if (!pnlMain.Controls.Contains(Pocetna.instance))
            {
                
                pnlMain.Controls.Add(Pocetna.instance);
                Pocetna.instance.Dock = DockStyle.Fill;
                Pocetna.instance.BringToFront();
            }
            else
            {
                Pocetna.ListaObavijesti = baza.Obavijesti.ToList();
                Pocetna.instance.Ucitaj();
                Pocetna.instance.BringToFront();
            }
        }

        private void UcitajObavijesti()
        {
            
        }

        private void btnTestovi_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTestovi.Height;
            pnlNav.Top = btnTestovi.Top;
            btnTestovi.BackColor = Color.FromArgb(46, 51, 73);
            //SetActivePanel(testovi1);
        }

        private void btnTermini_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTermini.Height;
            pnlNav.Top = btnTermini.Top;
            btnTermini.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnPrisustva_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPrisustva.Height;
            pnlNav.Top = btnPrisustva.Top;
            btnPrisustva.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnUspjeh_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnUspjeh.Height;
            pnlNav.Top = btnUspjeh.Top;
            btnUspjeh.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnLicniPodaci_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLicniPodaci.Height;
            pnlNav.Top = btnLicniPodaci.Top;
            btnLicniPodaci.BackColor = Color.FromArgb(46, 51, 73);
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

        private void btnTermini_Leave(object sender, EventArgs e)
        {
            btnTermini.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPrisustva_Leave(object sender, EventArgs e)
        {
            btnPrisustva.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnUspjeh_Leave(object sender, EventArgs e)
        {
            btnUspjeh.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLicniPodaci_Leave(object sender, EventArgs e)
        {
            btnLicniPodaci.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPostavke_Leave(object sender, EventArgs e)
        {
            btnPostavke.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnOdjava_Leave(object sender, EventArgs e)
        {
            btnOdjava.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPotvrde_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPotvrde.Height;
            pnlNav.Top = btnPotvrde.Top;
            btnPotvrde.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnPotvrde_Leave(object sender, EventArgs e)
        {
            btnPotvrde.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
