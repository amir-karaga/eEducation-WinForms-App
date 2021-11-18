using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eEducation.MainClasses
{
    public class Odgovor
    {
        public int Id { get; set; }
        public  string Tekst { get; set; }
        public bool jeTacan { get; set; }
        public bool  StudentOdg { get; set; }
    }
}
