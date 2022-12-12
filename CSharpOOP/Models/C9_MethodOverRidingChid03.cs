using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C9_MethodOverRidingChid03 : C9_MethodOverRidingBase
    {
        public float SalaryPerProject;

        public override string FullName()
        {
            return "Child03 " + this.FirstName + " " + this.LastName;
        }
    }
}
