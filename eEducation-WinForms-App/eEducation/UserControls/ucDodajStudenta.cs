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
    public partial class ucDodajStudenta : UserControl
    {
        KonekcijaNaBazu baza = eEducationDataBase.Baza;
        bool Edit = false;
        Student student;
        public ucDodajStudenta()
        {
            InitializeComponent();
        }
        public ucDodajStudenta(Student student) : this()
        {
            this.student = student;
            Edit = true;
            btnDodajStudenta.Text = "Spasi promjene";
            btnDodajSliku.Text = "Promjeni sliku";
        }
        private void ucDodajStudenta_Load(object sender, EventArgs e)
        {
            UcitajSpolove();
            if(Edit)
            UcitajPodatkeOStudentu();
        }
        private void UcitajPodatkeOStudentu()
        {
            txtIme.Text = student.Ime;
            txtPrezime.Text = student.Prezime;
            txtEmail.Text = student.Email;
            txtSifra.Text = student.Sifra;
            dtpDatumRodjenja.Value = DateTime.Parse(student.DatumRodjenja);
            txtMjestoPrebivalista.Text = student.MjestoPrebivalista;
            txtMjestoRodjenja.Text = student.MjestoRodjenja;
            txtNacionalnost.Text = student.Nacionalnost;
            txtDrzavljanstvo.Text = student.Drzavljanstvo;
            cmbSpolovi.SelectedItem = student.Spol;
            pbSlikaStudenta.Image = ImageHelpers.FromByteToImage(student.Slika);
            txtJMBG.Text = student.JMBG.ToString();
            txtBrIndexa.Text = student.BrojIndeksa;
            cmbGodinaStudija.SelectedItem = student.GodinaStudija.ToString();
            cmbStatusStudenta.SelectedItem = student.Status;
            if (student.Aktivan)
                cmbAktivan.SelectedItem = "Da";
            else
                cmbAktivan.SelectedItem = "Ne";
        }
        private void UcitajSpolove()
        {
            cmbSpolovi.DataSource = baza.Spolovi.ToList();
            cmbSpolovi.ValueMember = "Id";
            cmbSpolovi.DisplayMember = "Naziv";
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                if(!Edit)
                {
                    this.student = new Student();
                }

                student.Ime = txtIme.Text;
                student.Prezime = txtPrezime.Text;
                student.Email = txtEmail.Text;
                student.Sifra = txtSifra.Text;
                student.DatumRodjenja = dtpDatumRodjenja.Value.ToString("dd.MM.yyyy");
                student.MjestoPrebivalista = txtMjestoPrebivalista.Text;
                student.MjestoRodjenja = txtMjestoRodjenja.Text;
                student.Nacionalnost = txtNacionalnost.Text;
                student.Drzavljanstvo = txtDrzavljanstvo.Text;
                student.Spol = cmbSpolovi.SelectedItem as Spol;
                student.Slika = ImageHelpers.FromImageToByte(pbSlikaStudenta.Image);
                student.JMBG = long.Parse(txtJMBG.Text);
                student.Status = cmbStatusStudenta.SelectedItem.ToString();
                student.BrojIndeksa = txtBrIndexa.Text;
                student.GodinaStudija = int.Parse(cmbGodinaStudija.SelectedItem.ToString());
                if (cmbAktivan.SelectedItem.ToString() == "Da")
                    student.Aktivan = true;
                else
                    student.Aktivan = false;
                if (!Edit)
                {
                    baza.Studenti.Add(student);
                    MessageBox.Show("Student uspjesno dodan");
                }
                else
                {
                    baza.Entry(student).State = System.Data.Entity.EntityState.Modified;
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
                && Validator.ValidirajKontrolu(txtBrIndexa, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(pbSlikaStudenta, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtJMBG, err, Poruke.ObaveznaVrijednost);
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            if (ofdOdabirSlike.ShowDialog() == DialogResult.OK)
            {
                pbSlikaStudenta.Image = Image.FromFile(ofdOdabirSlike.FileName);
            }
        }
    }
}
