using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eEducation.MainClasses
{
    [Table("Obavijesti")]
    public class Obavijest
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public string Datum { get; set; }
        public string Autor { get { if (Profesor == null)
                    return $"{Administrator.Ime} {Administrator.Prezime}";
                return $"{Profesor.Ime} {Profesor.Prezime}";
            }  }
        public virtual Predmet Predmet { get; set; }
        public virtual Profesor Profesor { get; set; }
        public virtual Administrator Administrator { get; set; }
    }
}
