using eEducation.Helpers;
using eEducation.MainClasses;
using eEducation.UserControls;
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
    public partial class frmProfilAdministracija : Form
    {
        KonekcijaNaBazu baza = eEducationDataBase.Baza;
        Administrator administrator;
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
        public frmProfilAdministracija()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        public frmProfilAdministracija(Administrator administrator) : this()
        {
            this.administrator = administrator;
        }
        private void btnPocetna_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPocetna.Height;
            pnlNav.Top = btnPocetna.Top;
            pnlNav.Left = btnPocetna.Left;
            btnPocetna.BackColor = Color.FromArgb(46, 51, 73);
            if (!pnlMain.Controls.Contains(PocetnaAdministracija.instance))
            {
                pnlMain.Controls.Add(PocetnaAdministracija.instance);
                PocetnaAdministracija.instance.Dock = DockStyle.Fill;
                PocetnaAdministracija.instance.BringToFront();
                PocetnaAdministracija.instance.GenerisiAdministratora(administrator);
            }
            else
            {
                PocetnaAdministracija.ListaObavijesti = baza.Obavijesti.ToList();
                PocetnaAdministracija.instance.Ucitaj();
                PocetnaAdministracija.instance.BringToFront();
            }
        }

        private void btnProfesori_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProfesori.Height;
            pnlNav.Top = btnProfesori.Top;
            btnProfesori.BackColor = Color.FromArgb(46, 51, 73);
            if (!pnlMain.Controls.Contains(ucProfesori.instance))
            {
                pnlMain.Controls.Add(ucProfesori.instance);
                ucProfesori.instance.Dock = DockStyle.Fill;
                ucProfesori.instance.BringToFront();
                
            }
            else
            {
                ucProfesori.instance.Show();
                ucProfesori.ListaProfesori = baza.Profesori.ToList();
                ucProfesori.instance.Ucitaj();
                ucProfesori.instance.BringToFront();
            }
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

        private void btnStudenti_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnStudenti.Height;
            pnlNav.Top = btnStudenti.Top;         
            btnStudenti.BackColor = Color.FromArgb(46, 51, 73);
            if (!pnlMain.Controls.Contains(ucStudenti.instance))
            {
                pnlMain.Controls.Add(ucStudenti.instance);
                ucStudenti.instance.Dock = DockStyle.Fill;
                ucStudenti.instance.BringToFront();

            }
            else
            {
                ucStudenti.instance.Show();
                ucStudenti.ListaStudenti = baza.Studenti.ToList();
                ucStudenti.instance.UcitajStudente();
                ucStudenti.instance.BringToFront();
            }
        }

        private void btnPocetna_Leave(object sender, EventArgs e)
        {
            btnPocetna.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnProfesori_Leave(object sender, EventArgs e)
        {
            btnProfesori.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnStudenti_Leave(object sender, EventArgs e)
        {
            btnStudenti.BackColor = Color.FromArgb(24, 30, 54);
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

        private void frmProfilAdministracija_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOAdministratoru();
        }

        private void UcitajPodatkeOAdministratoru()
        {
            pbSlika.Image = ImageHelpers.FromByteToImage(administrator?.Slika);
            lblIme.Text = $"{administrator.Ime} {administrator.Prezime}";
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPredmeti_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucPredmeti.instance))
            {
                pnlMain.Controls.Add(ucPredmeti.instance);
                ucPredmeti.instance.Dock = DockStyle.Fill;
                ucPredmeti.instance.BringToFront();

            }
            else
            {
                ucPredmeti.instance.Show();
                ucPredmeti.ListaPredmeti = baza.Predmeti.ToList();
                ucPredmeti.instance.UcitajPredmete();
                ucPredmeti.instance.BringToFront();
            }
        }
    }
}
