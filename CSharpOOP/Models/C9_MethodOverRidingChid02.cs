using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C9_MethodOverRidingChid02 : C9_MethodOverRidingBase
    {
        public float SalaryPerHour;

        public override string FullName()
        {
            return "Child02 " + this.FirstName + " " + this.LastName;
        }
    }
}
