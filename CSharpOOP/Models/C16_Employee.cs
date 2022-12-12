using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C16_Employee : IC16_ExplicitInterface01, IC16_ExplicitInterface02
    {
        //Interface 02
        string IC16_ExplicitInterface02.PrintDetail()
        {
            return "C16 Interface 02 Method Called";
        }

        //Interface 01
        string IC16_ExplicitInterface01.PrintDetail()
        {
            return "C16 Interface 01 Method Called";
        }

       
    }
}
