using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C8_PolymorphismChild02 : C8_PolymorphismBase
    {
        public float SalaryPerHour;

        public new string FullName()
        {
            return "Child02 " + this.FirstName + " " + this.LastName;
        }
    }
}
