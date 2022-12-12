using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    class C11_Properties
    {
        private int _RollNumber;
        private string _StudentName;
        private string _FatherName;
        private float _TotalMarks;
        private float _Percentage;
        private DateTime _ExamDate = DateTime.Now;  //Return Current Date Time - Now = Property
        private bool _IsPassed;
        private string _Address;

        //Property RollNumber
        public int RollNumber
        {
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Error");
                }
                else
                {
                this._RollNumber = value;       //Std01.RollNumber = 101 (101 automatically passed into value keyword)
                }
            }

            get
            {
                return this._RollNumber;
            }
        }

        public string StudentName
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Error Std Name");
                }
                else
                {
                this._StudentName = value;
                }
            }

            get
            {
                return this._StudentName;
            }
        }

        public string FatherName
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Error Father Name");
                }
                else
                {
                    this._FatherName = value;
                }
            }

            get
            {
                return this._FatherName;
            }

        }

        public float TotalMarks
        {
            set
            {
                if(value < 0)
                {
                    throw new Exception("Total Marks Error");
                }
                else
                {
                this._TotalMarks = value;

                }
            }

            get
            {
                return this._TotalMarks;
            }

        }

        public float Percentage
        {

            get
            {
                this._Percentage = (this._TotalMarks / 500) * 100;
                return this._Percentage;
            }

        }

        public bool IsPassed
        {
            get
            {
                if(this._Percentage >= 70)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public DateTime ExamDate
        {
            get
            {
                return this._ExamDate;
            }
        }

        //Auto Implemented Property
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }

        public string Address
        {
            get
            {
                return _Address;
            }

            set
            {
                _Address = value;
            }
        }
    }
}
