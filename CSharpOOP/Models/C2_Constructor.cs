using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C2_Constructor
    {

        //Create Constructor
        public C2_Constructor()
        {
            Console.WriteLine("Class Instance Created and Constuctor called successfully");
            this.ExamDate = DateTime.Now;  //Return Current Date Time - Now = Property
        }

        public C2_Constructor(int mRollNumber)
        {
            this.RollNumber = mRollNumber;
        }

        public C2_Constructor(string mStudentName)
        {
            this.StudentName = mStudentName;
        }

        public C2_Constructor(int mRollNumber, string mStdName, string mFatherName, float mTotMarks, float mPercentage)
        {
            this.RollNumber = mRollNumber;
            this.StudentName = mStdName;
            this.FatherName = mFatherName;
            this.TotalMarks = mTotMarks;
            this.Percentage = mPercentage;
        }

        //Create Fields in class Student
        public int RollNumber;
        public string StudentName;
        public string FatherName;
        public float TotalMarks;
        public float Percentage;
        public DateTime ExamDate;
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


         ~C2_Constructor()
        {
            Console.WriteLine("Free up resounces here.... ");
            Console.ReadLine();
        }
    }
}
