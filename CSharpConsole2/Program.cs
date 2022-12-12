using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringClass();

            //StringBuilder();

            //DateTimeStruct();

            //VarKeyword();

            //AnonymousType();

            //DynamicType();

            //NullableType();

            //EnumType();

            //ExceptionTopic();

            //ExceptionTopic2();

            //ExceptionTopic3();

            //ExceptionTopic4();

            //ExceptionTopic5();

            //MultiDimArray();

            //ArrayListTopic();

            //ListCollection();
        }

        private static void ListCollection()
        {
            //Collection Object - Same as Arrays 
            //List is Generic <T>
            //System.Collections.Generic namespace
            //List<T> can contain elements of the specified <T>.
            //It Provides Compile Time Type Checking and does not perform boxing-unboxing because its a Generic.

            //Create
            List<int> myNumList = new List<int>();

            //Add Items
            myNumList.Add(200);
            myNumList.Add(300);
            myNumList.Add(150);

            foreach (int i in myNumList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"Count = {myNumList.Count}");

            List<string> StringList = new List<string>();

            StringList.Add("Karachi");
            StringList.Add("Jahra");
            StringList.Add("Islamabad");
            StringList.Add("Kuwait");
            StringList.Add("London");

            foreach (string i in StringList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"Count = {StringList.Count}");

            string City03 = StringList[2];
            Console.WriteLine($"City 03 = {City03}");

            //Assign Value using Collection Initializer Syntax
            List<int> NumList = new List<int>() { 1, 4, 7, 3, 9, 45 };

            //Create Custom Class List Object
            List<Student> StudentList = new List<Student>();
            Student St01 = new Student() { RollNumber = 101, FirstName = "Sohail" };
            Student St02 = new Student() { RollNumber = 102, FirstName = "Faisal" };
            Student St03 = new Student() { RollNumber = 103, FirstName = "Nabeel" };
            Student St04 = new Student() { RollNumber = 104, FirstName = "Raheel" };

            StudentList.Add(St01);
            StudentList.Add(St02);
            StudentList.Add(St03);
            StudentList.Add(St04);

            //Directly Add 
            StudentList.Add(new Student() { RollNumber = 105, FirstName = "Nabeel" });
            StudentList.Add(new Student() { RollNumber = 106, FirstName = "Hassaan" });
            StudentList.Add(new Student() { RollNumber = 107, FirstName = "Umair" });

            foreach (Student st in StudentList)
            {
                Console.WriteLine($"{st.RollNumber}, {st.FirstName}");
            }

            Console.WriteLine("Add Range of Example");
            //AddRange Method - Add Collection Object
            List<int> NumList02 = new List<int>();
            int[] nums = { 1, 3, 5, 7, 9 };
            

            NumList02.Add(1002);
            NumList02.Add(1012);
            NumList02.Add(201);

            /*AddRange Logic
            foreach(int arraynum in nums)
            {
                NumList02.Add(arraynum);
            }*/

            NumList02.AddRange(nums);
            NumList02.AddRange(NumList);


            //Insert - Add Element at specific indx position
            NumList02.Insert(5, 201);
            //NumList02[4] = 67; Override

            //InsertRange - Insert Collection
            //NumList02.InsertRange()

            //Remove - Remove Element
            //NumList02.RemoveAt(5);
            //NumList02.RemoveRange()
            NumList02.Remove(201);  //Removes 1st Occurance of given value
            NumList02.Remove(206);  //if not found then returns false - 0

            //Contains - Return true or false
            Console.WriteLine($"Containes 206 = {NumList02.Contains(206)}");

            //Sort

            foreach (int num in NumList02)
            {
                Console.Write($"{num} ");
            }

            NumList02.Sort();

            Console.WriteLine("After Sort");
            foreach (int num in NumList02)
            {
                Console.Write($"{num} ");
            }

            //Reverse - After Sort, it will be like Desc Sort
            //Reverse - without Sort, it will only reverse existing items

            NumList02.Reverse();
            Console.WriteLine();
            Console.WriteLine("Revere Order");
            foreach (int num in NumList02)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();
            Console.WriteLine("To String");
            Console.WriteLine(NumList02.ToString());

            //MyList<int> MyList01 = new MyList<int>();
            

            Console.ReadLine();

        }

        private static void ArrayListTopic()
        {
            //Array List is a non Generic Collection of Objects.
            //Different Data types 
            //Size will increase dynamically.
            //Can be used to add uknown data where you dont know the data types and the size of collection.
            //System.Collections Namespace.


            object myobj;

            myobj = 200;
            int a;

            a = (int)myobj;

            //Declare ArrayList
            ArrayList List01 = new ArrayList();

            Console.WriteLine($"Capacity = {List01.Capacity}");

            //Add Element
            List01.Add(200);
            List01.Add("Sohail");
            List01.Add(45.67F);
            List01.Add(true);

            Console.WriteLine(List01.Count);

            for(int i=0;i<(List01.Count);i++)
            {
                Console.WriteLine(List01[i]);
            }

            foreach(object j in List01)
            {
                Console.WriteLine(j);
            }

            string Str1 = (string)List01[1];
            object Str2 = List01[1];

            Console.WriteLine($"Capacity = {List01.Capacity}");
            List01.Add("Kuwait");
            List01.Add(100);
            List01.Capacity = 6;
            List01.Add(10);

            Console.WriteLine($"Capacity 02 = {List01.Capacity}");

            Console.ReadLine();
            
        }

        private static void MultiDimArray()
        {
            //2D Array Declaration and Initialization
            int[,] Array1 = new int[3, 2]
                                    {
                                        {2,3},
                                        {4,6},
                                        {5,8}
                                    };

            //Printing 2D Array
            Console.WriteLine("Printing 2D Array");
            for(int i=0; i<3; i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write($"{Array1[i,j]} ");
                }
                Console.WriteLine();
            }


            //3D Array Declaration and Initialization
            int[, ,] Array2 = new int[2,3,5]
                                    {
                                        { {2,4,6,8,10}, {1,3,5,7,9}, {5,10,15,20,25} },
                                        { {30,31,32,33,34}, {41,43,45,47,49}, {55,50,53,52,23} }
                                    };

            //Printing 3D Array
            Console.WriteLine("Printing 3D Array");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for(int k=0;k<5;k++)
                    {
                    Console.Write($"{Array2[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }

        private static void ExceptionTopic5()
        {
            Student st02 = new Student();
            st02.RollNumber = 102;
            //st02.FirstName = "Sohail";
            string strdetail = st02.PrintDetail();

            Console.ReadLine();
        }

        private static void ExceptionTopic4()
        {
            //Throw Exception

            try
            {
                int[] abc = { 1, 2, 3, 4, 5, 6 };
                Console.WriteLine("This is my another code before error......");

                Console.WriteLine(abc[0]);
                Console.WriteLine("This is my another code within try block......");
                int a = 1;
                int b = 1;
                if(a==0)
                {
                    throw new DivideByZeroException("Invalid Value.....");
                }
                Console.WriteLine(b / a);
                Console.ReadLine();

                //Student st01 = null;
                //PrintStudentName(st01);

                Student st02 = new Student();
                st02.RollNumber = 102;
                //st02.FirstName = "Sohail";
                string strdetail = st02.PrintDetail();

                int xyz;
                Console.WriteLine("Enter a number: ");
                xyz = int.Parse(Console.ReadLine());
                Console.WriteLine($"value of xyz = {xyz}");


            }

            //base class which contains all the exceptions
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("There are some error in the program.");
                Console.WriteLine(ex.Message);  //Only Exception Message
                Console.WriteLine(ex.StackTrace);   //Full Exception Detail
                //Console.WriteLine(ex.InnerException);
                Console.ReadLine();
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide a value by 0");
                Console.WriteLine($"Erorr Occured...{ex.Message}");
                Console.ReadLine();
            }

            catch(NullReferenceException ex)
            {
                Console.WriteLine("Error FOund");
                Console.WriteLine($"Erorr Occured...{ex.Message}");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erorr Occured...{ex.Message}");
                Console.WriteLine($"Exception Type: {ex.GetType().Name}");
                Console.WriteLine($"Exception Type: {ex.GetType().FullName}");
                Console.ReadLine();
            }

            //finally block will exexute in error or without error case
            finally
            {
                //clean up 
                Console.WriteLine("Now finally block executing.....");
                Console.ReadLine();
            }

        }

        private static void PrintStudentName(Student st01)
        {
            if(st01==null)
            {
                throw new NullReferenceException("Student class cannot be Null");
            }
        }

        private static void ExceptionTopic3()
        {
            //catch with specfic exception

            try
            {
                int[] abc = { 1, 2, 3, 4, 5, 6 };
                Console.WriteLine("This is my another code before error......");

                Console.WriteLine(abc[0]);
                Console.WriteLine("This is my another code within try block......");
                int a = 1;
                int b = 0;
                Console.WriteLine(b / a);
                Console.ReadLine();

                int xyz;
                Console.WriteLine("Enter a number: ");
                xyz = int.Parse(Console.ReadLine());
                Console.WriteLine($"value of xyz = {xyz}");


            }

            //base class which contains all the exceptions
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("There are some error in the program.");
                Console.WriteLine(ex.Message);  //Only Exception Message
                Console.WriteLine(ex.StackTrace);   //Full Exception Detail
                //Console.WriteLine(ex.InnerException);
                Console.ReadLine();
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide a value by 0");
                Console.ReadLine();
            }

            catch(Exception ex)
            {
                Console.WriteLine($"Erorr Occured...{ex.Message}");
                Console.WriteLine($"Exception Type: {ex.GetType().Name}");
                Console.WriteLine($"Exception Type: {ex.GetType().FullName}");
                Console.ReadLine();
            }

            //finally block will exexute in error or without error case
            finally
            {
                //clean up 
                Console.WriteLine("Now finally block executing.....");
                Console.ReadLine();
            }

        }
        private static void ExceptionTopic2()
        {
            //catch with exception

            try
            {
                int[] abc = { 1, 2, 3, 4, 5, 6 };
                Console.WriteLine("This is my another code before error......");

                Console.WriteLine(abc[30]);
                Console.WriteLine("This is my another code within try block......");
                int a = 1;
                int b = 0;
                Console.WriteLine(a/b);
                Console.ReadLine();
            }

            //base class which contains all the exceptions
            catch(Exception ex)
            {
                Console.WriteLine("There are some error in the program.");
                Console.WriteLine(ex.Message);  //Only Exception Message
                Console.WriteLine(ex.StackTrace);   //Full Exception Detail
                //Console.WriteLine(ex.InnerException);
                Console.ReadLine();
            }

            //finally block will exexute in error or without error case
            finally
            {
                //clean up 
                Console.WriteLine("Now finally block executing.....");
                Console.ReadLine();
            }

        }
        private static void ExceptionTopic()
        {
            //In C#, .Net provides built-in exception classes for every possible error.
            //Compile Time and Run Time.
            //Compile Time No issue.
            //Bydefault Runtime Exception can crash the running program after showing the exception message.

            //How to Handle Runtime Exception so we can control 
            //Base Class = Exception

            //Syntax
            //try { } - Surrounded by a code which can produce run time error.
            //catch { } - handle exception
            //finally { } - after handle exception - Cleanup resources... 


            //whenever error occurs, catch block will handle the control and then terminates the rpogram.
            try
            {
                int[] abc = { 1, 2, 3, 4, 5, 6 };
                Console.Write("This is my another code before error......");

                Console.WriteLine(abc[20]);
                Console.Write("This is my another code within try block......");

                Console.ReadLine();
            }

            catch
            {
                Console.Write("There are some error in the program.");
                Console.ReadLine();
            }

            //finally block will exexute in error or without error case
            finally
            {
                    //clean up 
                Console.WriteLine("Now finally block executing.....");
                Console.ReadLine();
            }
            
        }

        private static void EnumType()
        {
            //Creating a Gender list using Class
            //1 = Male
            //2 = Female
            //3 = Other
            //Read Only

            int UserGender = 2;

            //Readablity is not clear if we use the numeric codes like 1,2 3 in the code

            #region
            //using Class
            if (UserGender==Gender.Male)
            {
                // Perform Male Gender Task
                Console.WriteLine("Gener is Male");
            }
            else if (UserGender==Gender.Female)
            {
                Console.WriteLine("Gender is Female");
            }
            else if (UserGender==Gender.Others)
            {
                Console.WriteLine("Gender is Other");
            }
            else
            {
                Console.WriteLine("Invalid Gender");

            }
            #endregion

            #region UsingEnum
            if (UserGender == (int)(GenderList.Male))
            {
                // Perform Male Gender Task
                Console.WriteLine($"Gener is {GenderList.Male}");
            }
            else if (UserGender == (int)(GenderList.Female))
            {
                Console.WriteLine($"Gender is {GenderList.Female}");
            }
            else if (UserGender == (int)(GenderList.Others))
            {
                Console.WriteLine($"Gender is {GenderList.Others}");
            }
            else
            {
                Console.WriteLine("Invalid Gender");
            }
            #endregion

            Console.WriteLine(EnumWeekDays.Saturday);

            //Use Type Cast to get integer 

            Console.WriteLine((int)EnumWeekDays.Saturday);

            //Reverse type cast
            int weekday = 5;
            EnumWeekDays DOW = (EnumWeekDays)weekday;
            var DOW1 = (EnumWeekDays)weekday;

            Console.WriteLine((EnumWeekDays)weekday);
            Console.WriteLine(DOW);
            Console.WriteLine(DOW1);

            if(DOW == EnumWeekDays.Friday)
            {

            }

            Console.ReadLine();
        }

        private static void NullableType()
        {
            //By default Value Types cannot be NULLABLE.
            //To Make it Nullable we need to use Nullable Type.
            //Nullable is a Generic Type
            //Syntax:
            //Nullable<Type>
            //<> represents Generic Type.

            int a;  //Non Generic 
           // a = null; //a cannot be null 

            //I want to declare nullable int variable
            Nullable<int> b;
            b = null;

            Console.WriteLine($"Value of b = {b}");
            
            a = 200;

            if(a>b)
            {
                Console.WriteLine("a is greater");
            }
            else
            {
                Console.WriteLine("a is not greater");
            }

            //If we try to access Nullable value using its value property compiller will generate error if not a valid value assigned.
            //b = 200;
            Console.WriteLine($"Value of b using prop = {b}");

            Nullable<int> c = null;
            int sum;

            //if c has a valid value then the below two examples will perform ok
            //c = 200;
            //sum = (int)(a + c);
            //or
            //sum = (int)(a + c.Value);

            //if c has a null value then 
            //c = 200;
            if(c==null)
            {
                sum = (int)(a + 0);
            }
            else
            {
                sum = (int)(a + c);
            }
            
            //or
            //sum = (int)(a + c.Value);

            Console.WriteLine($"value of sum = {sum}");

            Console.WriteLine($"value of c = {c}");
   
            Console.WriteLine($"value of c = {c.GetValueOrDefault(100)}");

            sum = (a + c.GetValueOrDefault());
            Console.WriteLine($"value of sum = {sum}");

            //cannot assign null into non nullable
            Nullable<int> abc = null;
            int xyz = abc ?? 0; //if abc = null then assign 0


            //shorthand for Nullable
            int? x= null;



            Console.ReadLine();

        
        }

        private static void DynamicType()
        {
            //C# 4.0 (.Net 4.5) new type called Dynamic that avoids compile type checking.
            //Runtime it will define type
            int a = 200;
            
            dynamic num;
            //Console.WriteLine($"Type of num = {num.GetType()}");

            num = 200;
            
            Console.WriteLine($"Type of num = {num.GetType()}");
            Console.ReadLine();

            num = 4.278F;
            Console.WriteLine($"Type of num = {num.GetType()}");
            Console.ReadLine();

            num = "hello";
            Console.WriteLine($"Type of num = {num.GetType()}");
            Console.ReadLine();

            num = new Student();
            
            Console.WriteLine($"Type of num = {num.GetType()}");
            Console.ReadLine();

            //Implicit Type Casting
            num = 100;
            int i = num;

            num = "Sohail";
            string st = num;

            num = DateTime.Now;
            DateTime dt = num;

            //VS Intellense is not supported.
            //Object Members and Methods etc will not show.






        }

        private static void AnonymousType()
        {
            // In C # Anonymous Type is a type (Class) wihout any name that can contain public read only properties only. 
            //It cannot contains any other members like methods, fields etc.
            //Return Data is Unknown - How many Fields / Columns values will return
            //var keyword will be used to create Anonymous  Type Object
            //new keyword will be used to initalize data

            var MyStudent = new { ID = 101, Name = "Sohail" };

            Student Std = new Student()
            {
                RollNumber = 101,
                FirstName = "Nabeel"
            };

            var MyStudent2 = new { RollNumber = Std.RollNumber, FirstName = Std.FirstName };

            // MyStudent.ID = 200;   //Error - Only Read Only Property, Cannot Set Value

            //Nested 
            var MyStd = new
            {
                Name = "Sohail",
                FatherName = "Abdul Habib",
                Address = new { City = "Karachi", Country = "Pakistan" }
            };

            Console.WriteLine($"Name = {MyStd.Name}, Father = {MyStd.FatherName}, City = {MyStd.Address.City}, Country = {MyStd.Address.Country}");

            //Array 
            var MyList = new[]
            {
                new {id=1,Name="Sohail",Father="Abdul Habib"},
                new {id=2,Name="Faisal",Father="Abdul Habib"},
                new {id=2,Name="Raheel",Father="Abdul Habib"}
            };

           foreach(var nlist in MyList)
            {
                Console.WriteLine($"{nlist.id}, {nlist.Name}, {nlist.Father}");
            }

            Console.ReadLine();
        }

        private static void VarKeyword()
        {
            int num = 200;  //User already knows the data type

            var num2 = "100"; //User does not know the return type of value

            //var st;   //cannot use

            Student St01 = new Student();   //Fastest
            var St02 = new Student();       //Slow Performance

            //num2 = 456;   //Once Compiller Defined the type it cannot change.

            var DT = DateTime.Now + new TimeSpan(15, 10, 10, 15);


        }

        private static void DateTimeStruct()
        {
            //C# provides DateTime Structure to work on Date and Time

            //Create DateTime Object
            DateTime DOB = new DateTime();  //Default DateTme 01/01/0001 00:00:00
            DateTime DOB1 = new DateTime(2000, 11, 30); //Spefic Date
            DateTime DOB2 = new DateTime(2000, 11, 30, 08, 12, 30); //Specfic Date and Time
            DateTime DOB3 = new DateTime(636123456789); //Ticks - Add 100-nanoseconds into its default datetime against 1 Tick.
            DateTime DOB4 = new DateTime();
            DateTime DOB5 = new DateTime();
            DateTime DOB6 = new DateTime();
            DateTime DOB7 = new DateTime();
            DateTime DOB8 = new DateTime();

            

            Console.WriteLine(DOB);
            Console.WriteLine(DOB1);
            Console.WriteLine(DOB2);
            Console.WriteLine(DOB3);

            //Properites
            DOB4 = DateTime.Now;  //Current Date and Time
            DOB5 = DateTime.Today;  //Today Date
            DOB6 = DateTime.UtcNow; //Current UTC Date Time
            DOB7 = DateTime.MaxValue; //Maximum Date
            DOB8 = DateTime.MinValue; //Minimum
            Console.WriteLine($"Current Date Time = {DOB4}");
            Console.WriteLine($"Today Date = {DOB5}");
            Console.WriteLine($"Current UTC Date Time = {DOB6}");
            Console.WriteLine($"Max = {DOB7}");
            Console.WriteLine($"Minimum = {DOB8}");

            //Methods
            DateTime DOB9 = DOB4.AddDays(15); //Add 15 Days
            DayOfWeek DOW= DOB5.DayOfWeek;
            Console.WriteLine($"Day of Week = {DOB5.DayOfWeek}");
            Console.WriteLine($"DOW = {(int)DOW}");
            Console.WriteLine($"Add Days = {DOB9}");

            //Operator == > < >= <= !=
            Console.WriteLine(DOB4 < DOB9);

            //Convert String into DateTime
            string DT = "10/2/2001";
            DateTime DOB10;
            if (DateTime.TryParse(DT, out DOB10))
            {
                Console.WriteLine("Type Cast Ok");
            }
            else
            {
                Console.WriteLine("Type cast failed");
            }

            //Date to String
            String St1 = DOB10.ToLongDateString();

            Console.WriteLine($"Date to Str = {St1}");
            Console.WriteLine($"Date to Str = {DOB10.ToString()}");

            //Time Span is a strcuture that is used to represent time in days, hour, minutes, seconds and milliseconds

            DateTime DOB11 = DateTime.Now;
            TimeSpan TS01 = new TimeSpan(10, 30, 15);
            TimeSpan TS02 = new TimeSpan(10,10,30,15);

            Console.WriteLine($"Time Span = {TS01}");
            Console.WriteLine($"Time Span = {TS02}");
            Console.WriteLine($"dob11 = {DOB11}");
            Console.WriteLine($"DOB11 + TS01 = {DOB11 + TS01}");
            Console.WriteLine($"DOB11 + TS02 = {DOB11 + TS02}");
            Console.WriteLine($"DOB11 - TS02 = {DOB11 - TS02}");

            DateTime MyCurDate = DateTime.Now + new TimeSpan(15, 10, 10, 15);
            Console.WriteLine($"Current Date = {MyCurDate}");


            Console.ReadLine();
        }

        static void StringClass()
        {
            //two ways of Declare

            string st1; //keyword
            String st2; //System.String Class

            //In C#, String is a collection of characters (Character Array).
            st1 = "Sohail Abdul Habib";

            char ch;
            ch = 'A';
            ch = st1[2];    //34d element of st1 = h

            //string Iteration - Loop
            for (int a = 0; a < st1.Length; a++)
                Console.Write(st1[a]);

            Console.WriteLine();

            foreach (char c in st1)
                Console.Write(c);

            char[] strname = { 'S', 'o' };

            

            //String Class Property
            //Length

            //Methods.

            Console.WriteLine(st1.ToLower());
            Console.WriteLine(st1.ToUpper());
            Console.WriteLine(st1.Contains("ail"));
            Console.WriteLine(st1.IndexOf("a"));
            Console.WriteLine(st1.LastIndexOf("a"));



            Console.ReadLine();

            //Study System.String Class Library




        }

        static void StringBuilder()
        {
            //String Type is immutable. It means a string cannot be changed once created.

            string st1 = "Sohail";
            st1 = "Nabeel"; //it will not repalce Sohail with Nabeel, but it will createa new copy 

            //If we overrite st1 variable 100 times in our program, it will occupy 100 string spaces. All the old data exist in memory.
            //This may cause performance issue and memory issue.

            //Tol Solve this, Dot Net introduces StringBuilder.
            //String Builder doesnt not create a new object in the memory but overwrites the existing value.

            //Create StringBuilder Object
            StringBuilder St2 = new StringBuilder();
            StringBuilder St3 = new StringBuilder("My Name is Sohail");
            StringBuilder St4 = new StringBuilder(50);  //Allocates 50 Bytes and it will increase automatically by 50 bytes.
            StringBuilder St5 = new StringBuilder(50, 200); //Inital Capacity: 50, Maximum Capacity: 200;

            //Store 
            St2.Append("My Name is Raheel");    //Insert @ End
            St2.Append(" Habib");    //Insert @ End

            //Access - Read/Get
            Console.WriteLine(St2.ToString());
            Console.WriteLine(St3.ToString());
            Console.WriteLine(St2.Length);  //Get Length

            //Append Line
            St4.AppendLine("My Name");
            St4.AppendLine("is Nabeel");

            Console.WriteLine(St4.ToString());  //Get String

            //Append Formatted
            St5.Append("Total Product Price is: ");
            St5.AppendFormat("{0:C}", 1050);

            Console.WriteLine(St5.ToString());

            //Insert, Remove, Replace



            Console.ReadLine();
        }
    }

    public class MyList<T> : List<T>
    {
        public void MyMethod()
        {

        }
    }

    public class Student
    {
        public int RollNumber { get; set; }
        public string FirstName { get; set; }

        public string PrintDetail()
        {
            if(string.IsNullOrEmpty(this.FirstName))
            {
                throw new NullReferenceException("First Name is Null");
            }
            else
            {
                return $"{this.RollNumber} - {this.FirstName}";
            }
        }
    }

    public static class Gender
    {
        public static int Male { get; } = 1;
        public static int Female { get; } = 2;
        public static int Others { get; } = 3;
    }

    //By default Integer
    public enum GenderList: int
    {
        //Default starting value will be from 0
        Male=1,
        Female,
        Others
    }
}
