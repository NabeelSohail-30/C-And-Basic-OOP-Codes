using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C3_RefrenceType
    {
        //Create Fields in class Student
        public int RollNumber;
        public string StudentName;
        public string FatherName;
        public float TotalMarks;
        public float Percentage;
        public DateTime ExamDate = DateTime.Now;  //Return Current Date Time - Now = Property
        bool isPassed;

        public bool CalculatePassed()
        {

            if (this.Percentage >= 50)
            {
                this.isPassed = true;
            }
            else
            {
                this.isPassed = false;
            }

            return this.isPassed;
        }
    }
}
