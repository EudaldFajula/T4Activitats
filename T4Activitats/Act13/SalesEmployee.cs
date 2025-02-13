using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4Activitats.Act12;

namespace T4Activitats.Act13
{
    public class SalesEmployee : Employee
    {
        public float Commission { get; set; }
        //Act 13
        public SalesEmployee(string name, string lastName, DateTime dateBirth, string code, DateTime hireDate, float monthSalary, int payments, float commission) : base(name, lastName, dateBirth, code, hireDate, monthSalary, payments)
        {
            Commission = commission;
            _count++;
        }
        public SalesEmployee(string name, string lastName, DateTime dateBirth, string code, DateTime hireDate, float commission) : base(name, lastName, dateBirth, code, hireDate)
        {
            Commission = commission;
            _count++;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"-----------------------------------------------------------------------------------------------------\r\n                          S A L E S E M P L O Y E E\r\n-----------------------------------------------------------------------------------------------------\r\n");
            sb.Append(base.ToString());
            sb.Append($">Commission: {this.Commission}\r\n");
            return sb.ToString();
        } 
    }
}
