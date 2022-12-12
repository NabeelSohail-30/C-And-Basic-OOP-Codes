using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C6_ChildInherit : C6_Inheritance
    {
        // C6_ChildInherit Class inhertis from C6_Inheritance
        public int Age;
        public string Nationality;
        bool IsEligible;

        public C6_ChildInherit() : base(541)
        {
            Console.WriteLine("Derived Class Constructor called");
        }

        public C6_ChildInherit(int Age) : base()
        {

        }
    }
}
