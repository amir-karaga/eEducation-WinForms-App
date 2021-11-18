using eEducation.Helpers;
using eEducation.MainClasses;
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
    public partial class frmDodajObavijest : Form
    {
        KonekcijaNaBazu baza = eEducationDataBase.Baza;
        Administrator administrator=new Administrator();
        Test test = new Test();
        Pitanje pitanje = new Pitanje();
        Profesor Profesor = new Profesor();
        Obavijest obavijest;
        bool pregled;
        public frmDodajObavijest()
        {
            InitializeComponent();
        }
        public frmDodajObavijest(Profesor profesor):this()
        {
            lblAutor.Text = $"{profesor.Ime} {profesor.Prezime}";
            lblDatum.Text = DateTime.Now.ToString("dd.MM.yyyy");
            test.Profesor = profesor;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDodajObavijest_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
        }

        private void UcitajPredmete()
        {
            try
            {
                cmbPredmeti.DataSource = baza.Predmeti.ToList();
                cmbPredmeti.DisplayMember = "Naziv";
                cmbPredmeti.ValueMember = "Id";
                if (pregled)
                    cmbPredmeti.SelectedItem = obavijest.Predmet;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
            
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                test.pitanja.Add(pitanje);
                baza.SaveChanges();
                dgvPitanja.DataSource = null;
                dgvPitanja.DataSource = test.pitanja.ToList();
            }
        }

        private bool ValidirajUnos()
        { return Validator.ValidirajKontrolu(txtNaslov, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtSadrzaj, err, Poruke.ObaveznaVrijednost);
           
        }

        private void btnDodajOdg_Click(object sender, EventArgs e)
        {
            pitanje.Sadrzaj = txtSadrzaj.Text;
            pitanje.odgovori.Add(new Odgovor()
            {
                Tekst = txtOdgovor.Text,
                jeTacan = true,
                StudentOdg = false
            });
            MessageBox.Show("Odgovor dodan");
        }
    }
}
