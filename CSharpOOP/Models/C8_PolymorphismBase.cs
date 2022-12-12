using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C8_PolymorphismBase
    {
        //Employee Class - Common Fileds and Members
        //Child01 - Full Time Employee
        //Child02 - PartTime Employee
        //Child03 - Temp Employee

        public string FirstName;
        public string LastName;
        public string Gender;

        public string FullName()
        {
            return "Base " + this.FirstName + " " + this.LastName;
        }
    }
}
