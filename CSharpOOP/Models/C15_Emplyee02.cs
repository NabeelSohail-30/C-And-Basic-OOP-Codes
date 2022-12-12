using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C15_Emplyee02 : C15_EmployeeBase, IC15_Interface
    {
        /*
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Salary { get; set; }
        */
        public float CalculateOvertime(float salary)
        {
            return ((salary * 2) / 100);
        }

        public string Print()
        {
            return $"Part Time Employee - {this.EmployeeID} - {this.FirstName} - {this.LastName} - {this.Salary}";
        }
    }
}
