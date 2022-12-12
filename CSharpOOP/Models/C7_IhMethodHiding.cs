using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C7_IhMethodHiding
    {
        //Create Fields in class Student
        public int RollNumber;
        public string StudentName;
        public string FatherName;
        public float TotalMarks;
        public float Percentage;
        public DateTime ExamDate = DateTime.Now;  //Return Current Date Time - Now = Property
        public bool isPassed;

        public void CalculatePassed()
        {
            Console.WriteLine("Base Class Method Called.");

        }
    }
}
