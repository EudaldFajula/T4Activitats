using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4Activitats.Act12
{
    internal class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }
        public Employee(string name, string lastName, DateTime dateBirth)
        {
            Name = name;
            LastName = lastName;
            DateBirth = dateBirth;
        }
        public int CalculateAge() => (DateTime.Now.Year - this.DateBirth.Year);
    }
}
