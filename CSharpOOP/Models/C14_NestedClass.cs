using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    public class StudentProfile
    {
        public class Add
        {
            public int RollNumber { get; set; }
            public string StdName { get; set; }
            public string StdFatherName { get; set; }

        }

        public class Update : Add
        {
            public int StdId { get; set; }
            
        }
    }
}
