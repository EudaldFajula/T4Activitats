using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4Activitats.Act12
{
    internal class Employee
    {
        public static int _count = 0;
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }
        //Act 13
        public string Code { get; set; }
        public DateTime HireDate { get; set; }
        public float MonthSalary { get; set; }
        public int Payments { get; set; }


        public Employee(string name, string lastName, DateTime dateBirth, string code, DateTime hireDate, float monthSalary, int payments)
        {
            Name = name;
            LastName = lastName;
            DateBirth = dateBirth;
            Code = code;
            HireDate = hireDate;
            MonthSalary = monthSalary;
            Payments = payments;
        }
        public int CalculateAge() => (DateTime.Now.Year - this.DateBirth.Year);
        //Act13 
        public Employee(string name, string lastName, DateTime dateBirth, string code, DateTime hireDate) 
        {
            Name = name;
            LastName = lastName;
            DateBirth = dateBirth;
            Code = code;
            HireDate = hireDate;
            MonthSalary = 1800;
            Payments = 14;
            _count++;
        }
        public string GetFullName() => $"{this.Name}, {this.LastName}";
        public string GetFullNameReverse() => $"{this.LastName}, {this.Name}";
        public int GetAge() => CalculateAge();
        public int GetHireDate() => this.HireDate.Year;
        public float GetAnnualSalary() => this.MonthSalary  * 12;
        public override string ToString() => $"-----------------------------------------------------------------------------------------------------\r\n                           E M P L O Y E E\r\n-----------------------------------------------------------------------------------------------------\r\n>Code: {this.Code} \r\n>Firstname: {this.Name}\r\n>Last name:{this.LastName}\r\n>Full name: {GetFullName()}\r\n>Reverse name: {GetFullNameReverse()}\r\n>Age: {GetAge()}\r\n>Seniority: {GetHireDate()}\r\n>Annual salary: {GetAnnualSalary()}\r\n";
    }
}
