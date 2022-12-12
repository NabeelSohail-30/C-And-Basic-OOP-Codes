using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C6_Inheritance
    {
        //Create Fields in class Student
        public int RollNumber;
        public string StudentName;
        public string FatherName;
        public float TotalMarks;
        public float Percentage;
        public DateTime ExamDate = DateTime.Now;  //Return Current Date Time - Now = Property
        bool isPassed;

        public C6_Inheritance()
        {
            Console.WriteLine("Base Class Constructor Called.");
        }

        public C6_Inheritance(int RollNumber)
        {
            this.RollNumber = RollNumber;
            Console.WriteLine("Base Constructor with parameter Roll Num called");
        }

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

    // Base Class
    //ID, FirstName, LastName, Email, Phone, Nationality

    //Student Class Create
    //ID, FirstName, LastName, Email, Phone, Nationality, etc etc.

    //Instructor Class Create
    //ID, FirstName, LastName, Email, Phone, Nationality, etc etc.


    //Diploma 
    //Short Course
    //Coaching 


}
