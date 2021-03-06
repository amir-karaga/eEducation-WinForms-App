using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eEducation.MainClasses
{
    [Table("Predmeti")]
    public class Predmet
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public virtual Profesor Profesor { get; set; }
        public int ECTS { get; set; }
        public int GodinaStudija { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
