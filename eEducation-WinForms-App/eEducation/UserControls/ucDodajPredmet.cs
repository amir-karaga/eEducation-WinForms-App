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
    public partial class ucDodajPredmet : UserControl
    {
        KonekcijaNaBazu baza = eEducationDataBase.Baza;
        Predmet predmet;
        bool Edit = false;
        public ucDodajPredmet()
        {
            InitializeComponent();
        }
        public ucDodajPredmet(Predmet predmet):this()
        {
            this.predmet = predmet;
            Edit = true;
           
        }

        private void UcitajPodatkeOPredmetu()
        {
            txtECTS.Text = predmet.ECTS.ToString();
            txtNazivPredmeta.Text = predmet.Naziv;
            cmbProfesori.SelectedItem = predmet.Profesor;
            cmbGodinaStudija.SelectedItem = predmet.GodinaStudija.ToString();
            btnDodajPredmet.Text = "Spasi promjene";
        }

        private void ucDodajPredmet_Load(object sender, EventArgs e)
        {
                UcitajProfesore();
                cmbGodinaStudija.SelectedIndex = 0;
                cmbProfesori.SelectedIndex = 0;
            if(Edit)
            {
                UcitajPodatkeOPredmetu();
            }
            
        }

        private void UcitajProfesore()
        {
            cmbProfesori.DataSource = baza.Profesori.ToList();
            cmbProfesori.DisplayMember = "ImePrezime";
            cmbProfesori.ValueMember = "Id";
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDodajPredmet_Click(object sender, EventArgs e)
        {
            if(ValidirajUnos())
            {
                if (!Edit)
                {
                    predmet = new Predmet();
                }
                predmet.Naziv = txtNazivPredmeta.Text;
                predmet.Profesor = cmbProfesori.SelectedItem as Profesor;
                predmet.GodinaStudija = int.Parse(cmbGodinaStudija.SelectedItem.ToString());
                predmet.ECTS = int.Parse(txtECTS.Text);
                if (Edit)
                {
                    baza.Entry(predmet).State = System.Data.Entity.EntityState.Modified;
                    MessageBox.Show("Podaci uspjesno modifikovani");
                }
                else
                {
                    baza.Predmeti.Add(predmet);
                    MessageBox.Show("Predmet uspjesno dodan");
                }
                baza.SaveChanges();
            }
            
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(txtECTS, err, Poruke.ObaveznaVrijednost)
                 && Validator.ValidirajKontrolu(txtNazivPredmeta, err, Poruke.ObaveznaVrijednost);
        }
    }
}
