using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C8_PolymorphismChild01 : C8_PolymorphismBase
    {
        public float Salary;

        public new string FullName()
        {
            return "Child01 " + this.FirstName + " " + this.LastName;
        }
    }
}
