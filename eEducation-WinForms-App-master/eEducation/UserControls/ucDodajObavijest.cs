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

namespace eEducation.UserControls
{
    public partial class ucDodajObavijest : UserControl
    {
        KonekcijaNaBazu baza = eEducationDataBase.Baza;
        private static ucDodajObavijest _instance;
        Obavijest obavijest;
        Administrator administrator;
        bool pregled;
        public ucDodajObavijest()
        {
            InitializeComponent();

        }
        public ucDodajObavijest(Administrator administrator):this()
        {
            this.administrator = administrator;
            lblAutor.Text = $"{administrator.Ime} {administrator.Prezime}";
            lblDatum.Text = DateTime.Now.ToString();
        }
        public static ucDodajObavijest instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDodajObavijest();
                return _instance;
            }

        }
        public void GenerisiObavijest(Obavijest obavijest)
        {
            this.obavijest = obavijest;
            UcitajPodatkeObavijesti();
            pregled = true;
            btnSpasi.Hide();
        }
        private void UcitajPodatkeObavijesti()
        {
            lblAutor.Text = $"{obavijest.Administrator.Ime} {obavijest.Administrator.Prezime}";
            lblDatum.Text = obavijest.Datum;
            txtNaslov.Text = obavijest.Naslov;
            txtSadrzaj.Text = obavijest.Sadrzaj;
            cmbPredmeti.SelectedItem = obavijest.Predmet;
        }

        private void ucDodajObavijest_Load(object sender, EventArgs e)
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
        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                Predmet predmet = cmbPredmeti.SelectedItem as Predmet;
                Obavijest novaObavijest = new Obavijest()
                {
                    Sadrzaj = txtSadrzaj.Text,
                    Datum = DateTime.Now.ToString(),
                    Naslov = txtNaslov.Text,
                    Predmet = predmet,
                    Profesor = null,
                    Administrator = administrator
                };
                baza.Obavijesti.Add(novaObavijest);
                baza.SaveChanges();
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(txtNaslov, err, Poruke.ObaveznaVrijednost)
               && Validator.ValidirajKontrolu(txtSadrzaj, err, Poruke.ObaveznaVrijednost);
        }
    }
}
