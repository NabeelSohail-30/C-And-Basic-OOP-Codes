using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C9_MethodOverRidingChid01 : C9_MethodOverRidingBase
    {
        public float Salary;

        public override string FullName()
        {
            return "Child01 " + this.FirstName + " " + this.LastName;
        }
    }
}
