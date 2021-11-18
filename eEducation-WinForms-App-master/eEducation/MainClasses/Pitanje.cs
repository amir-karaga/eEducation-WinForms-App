using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eEducation.MainClasses
{
    public class Pitanje
    {
        //public int Id { get; set; }
        public string Sadrzaj { get; set; }

        public  List<Odgovor> odgovori = new List<Odgovor>();
    }
}
