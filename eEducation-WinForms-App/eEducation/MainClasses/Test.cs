using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eEducation.MainClasses
{
    [Table("Testovi")]
    public class Test
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public virtual Profesor Profesor { get; set; }
        public virtual Predmet Predmet { get; set; }
        public  List<Pitanje> pitanja=new List<Pitanje>();
    }
}
