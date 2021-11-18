using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eEducation.MainClasses
{
    [Table("Administratori")]
    public class Administrator
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Sifra { get; set; }
        public string Profesija { get; set; }
        public string DatumRodjenja { get; set; }
        public string Nacionalnost { get; set; }
        public string Drzavljanstvo { get; set; }
        public string MjestoRodjenja { get; set; }
        public string MjestoPrebivalista { get; set; }
        public byte[] Slika { get; set; }
        public Spol Spol { get; set; }
        public long JMBG { get; set; }
      
    }
}
