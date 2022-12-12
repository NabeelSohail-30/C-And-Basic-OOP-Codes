using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C7_IhMethodHidingChild : C7_IhMethodHiding
    {
        public string email;
        public new float Percentage;

        public new void CalculatePassed()
        {
            //base.CalculatePassed();
            Console.WriteLine("Derived Class Method Called.");
            //base.isPassed = false;
        }
    }
}
