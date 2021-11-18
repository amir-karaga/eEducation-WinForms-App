using eEducation.MainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eEducation.Helpers
{
    public class KonekcijaNaBazu:DbContext
    {
        public KonekcijaNaBazu():base("PutanjaDoBaze")
        {

        }
        public virtual DbSet<Student> Studenti { get; set; }
        public virtual DbSet<Profesor> Profesori { get; set; }
        public virtual DbSet<Administrator> Administratori { get; set; }
        public virtual DbSet<Spol> Spolovi { get; set; }
        public virtual DbSet<Obavijest> Obavijesti { get; set; }
        public virtual DbSet<Predmet> Predmeti { get; set; }
        public virtual DbSet<Test> Testovi { get; set; }
    }
}
