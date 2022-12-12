using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C8_PolymorphismChild03 : C8_PolymorphismBase
    {
        public float SalaryPerProject;

        public new string FullName()
        {
            return "Child03 " + this.FirstName + " " + this.LastName;
        }
    }
}
