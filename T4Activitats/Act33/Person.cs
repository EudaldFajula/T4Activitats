using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4Activitats.Act33
{
    public class Person
    {
        public string Nom { get; set; }
        public int Edat { get; set; }
        public string Ciutat { get; set; }
        public Person(string nom, int edat, string ciutat)
        {
            Nom = nom;
            Edat = edat;
            Ciutat = ciutat;
        }
    }
}
