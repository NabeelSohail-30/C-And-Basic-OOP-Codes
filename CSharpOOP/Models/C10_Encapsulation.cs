using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C10_Encapsulation
    {
        //Create Fields in class Student
        private int _RollNumber;
        private string _StudentName;
        public string FatherName;
        public float TotalMarks;
        public float Percentage;
        public DateTime ExamDate = DateTime.Now;  //Return Current Date Time - Now = Property
        private bool isPassed;

        public void SetRollNumber(int RollNumber)
        {
            if(RollNumber <=0)
            {
                //Business Validation here........
                //Error 
                throw new Exception("Invalid Roll Number.");
            }
            else
            { 
            this._RollNumber = RollNumber;
            }
        }

        public int GetRollNumber()
        {
            return this._RollNumber;
        }

        public void SetStudentName(string StudentName)
        {
            if (string.IsNullOrWhiteSpace(StudentName) || StudentName.Length < 3)
            {
                throw new Exception("Student Name cannot be NULL");
            }
            else
            {
                this._StudentName = StudentName;
            }
        }

        public string GetStudentName()
        {
            return this._StudentName;
        }

        public bool GetisPassed()
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
