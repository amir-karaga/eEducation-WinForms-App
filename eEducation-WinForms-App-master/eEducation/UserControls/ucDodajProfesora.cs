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
    public partial class ucDodajProfesora : UserControl
    {
        KonekcijaNaBazu baza = eEducationDataBase.Baza;
        Profesor profesor;
        bool Edit=false;
        public ucDodajProfesora()
        {
            InitializeComponent();
        }
        public ucDodajProfesora(Profesor profesor):this()
        {
            this.profesor = profesor;
            Edit = true;
            btnDodajProfesora.Text = "Spasi promjene";
            btnDodajSliku.Text = "Promjeni sliku";
        }

        private void UcitajPodatkeOProfesoru()
        {
            txtIme.Text = profesor.Ime;
            txtPrezime.Text = profesor.Prezime;
            txtEmail.Text = profesor.Email;
            txtSifra.Text = profesor.Sifra;
            dtpDatumRodjenja.Value = DateTime.Parse(profesor.DatumRodjenja);
            txtMjestoPrebivalista.Text = profesor.MjestoPrebivalista;
            txtMjestoRodjenja.Text = profesor.MjestoRodjenja;
            txtNacionalnost.Text = profesor.Nacionalnost;
            txtDrzavljanstvo.Text = profesor.Drzavljanstvo;
            cmbSpolovi.SelectedItem = profesor.Spol;
            pbSlikaProf.Image = ImageHelpers.FromByteToImage(profesor.Slika);
            txtJMBG.Text = profesor.JMBG.ToString();
            txtZvanje.Text = profesor.Zvanje;
            txtProfesija.Text = profesor.Profesija;
            cmbStatusProf.SelectedItem = profesor.Status;
        }

        private void ucDodajProfesora_Load(object sender, EventArgs e)
        {
            UcitajSpolove();
            if(Edit)
            UcitajPodatkeOProfesoru();
        }

        private void UcitajSpolove()
        {
            cmbSpolovi.DataSource = baza.Spolovi.ToList();
            cmbSpolovi.DisplayMember = "Naziv";
            cmbSpolovi.ValueMember = "Id";
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDodajProfesora_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                if(!Edit)
                {
                    this.profesor = new Profesor();
                }

                profesor.Ime = txtIme.Text;
                profesor.Prezime = txtPrezime.Text;
                profesor.Email = txtEmail.Text;
                profesor.Sifra = txtSifra.Text;
                profesor.DatumRodjenja = dtpDatumRodjenja.Value.ToString("dd.MM.yyyy");
                profesor.MjestoPrebivalista = txtMjestoPrebivalista.Text;
                profesor.MjestoRodjenja = txtMjestoRodjenja.Text;
                profesor.Nacionalnost = txtNacionalnost.Text;
                profesor.Drzavljanstvo = txtDrzavljanstvo.Text;
                profesor.Spol = cmbSpolovi.SelectedItem as Spol;
                profesor.Slika = ImageHelpers.FromImageToByte(pbSlikaProf.Image);
                profesor.JMBG = long.Parse(txtJMBG.Text);
                profesor.Zvanje = txtZvanje.Text;
                profesor.Profesija = txtProfesija.Text;
                profesor.Status = cmbStatusProf.SelectedItem.ToString();
                if (!Edit)
                {
                    baza.Profesori.Add(profesor);
                    MessageBox.Show("Profesor uspjesno dodan");
                }
                else
                {
                    baza.Entry(profesor).State = System.Data.Entity.EntityState.Modified;
                    MessageBox.Show("Podaci uspjesno modifikovani");
                }
                baza.SaveChanges();
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(txtIme, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtPrezime, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtEmail, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtSifra, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtMjestoPrebivalista, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtMjestoRodjenja, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtNacionalnost, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtDrzavljanstvo, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtProfesija, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtZvanje, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtJMBG, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(pbSlikaProf, err, Poruke.ObaveznaVrijednost);
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            if (ofdOdabirSlike.ShowDialog() == DialogResult.OK)
            {
                pbSlikaProf.Image = Image.FromFile(ofdOdabirSlike.FileName);
            }
        }
    }
}
