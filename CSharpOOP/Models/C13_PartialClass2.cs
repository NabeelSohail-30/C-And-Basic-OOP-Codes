﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    public partial class Student
    {
        public string GetFullName()
        {
            return this.StudentName;
        }
    }
}
