using CSharpOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{ 
    class Program
    {
        static void Main(string[] args)
        {

            //C1_CreatingClass();

            //C2_ClassConstructor();

            //C3_ClassType();

            //C4_cArray();

            //C5_ClassStaticMembers();

            //C6_ClassInheritance();

            //C7_MethodHiding();

            //C8_Polymorphism();

            //C9_MethodOverRiding();

            //C10_TopicEncapsulation();

            //C11_EncapProperties();

            //C12_StaticClassTopic();

            //C13_PartialClassTopic();

            //C14_NestedClassTopic();

            //C15_InterfaceTopic();

            //C16_ExplicitInt();

            //C17_AbstractionClass();
        }

        static void C1_CreatingClass()
        {
            //Chapter1_Student - Creating Class and its Members
            //Declare
            //Student Student1;

            //Initalize
            //Student1 = new Student();

            //Declare and Initalize
            C1_Student St1 = new C1_Student();

            St1.RollNumber = 101;
            St1.StudentName = "Sohail";
            St1.FatherName = "Abdul Habib";
            St1.TotalMarks = 455.56F;
            St1.Percentage = 65.66F;

            Console.WriteLine("Student Detail");
            Console.WriteLine($"Roll Number = {St1.RollNumber}");
            Console.WriteLine($"Student Name = {St1.StudentName}");
            Console.WriteLine($"Father Name = {St1.FatherName}");
            Console.WriteLine($"Total Marks = {St1.TotalMarks}");
            Console.WriteLine($"Percentage = {St1.Percentage}");
            Console.WriteLine($"Exam Date = {St1.ExamDate}");
            Console.WriteLine($"Student Passed = {St1.CalculatePassed()}");

            Console.ReadLine();

            C1_Student St2 = new C1_Student();

            St2.RollNumber = 102;
            St2.StudentName = "Nabeel";
            St2.FatherName = "Sohail Habib";
            St2.TotalMarks = 306.8F;
            St2.Percentage = 42.65F;

            Console.WriteLine();
            Console.WriteLine("Student Detail");
            Console.WriteLine($"Roll Number = {St2.RollNumber}");
            Console.WriteLine($"Student Name = {St2.StudentName}");
            Console.WriteLine($"Father Name = {St2.FatherName}");
            Console.WriteLine($"Total Marks = {St2.TotalMarks}");
            Console.WriteLine($"Percentage = {St2.Percentage}");
            Console.WriteLine($"Exam Date = {St2.ExamDate}");
            Console.WriteLine($"Student Passed = {St2.CalculatePassed()}");


            Console.ReadLine();


            C1_StudentFee St1Fee = new C1_StudentFee();
            St1Fee.RollNumber = St1.RollNumber;
            St1Fee.FeeAmount = 2500F;
            //St1Fee.FeeDate = Convert.ToDateTime("5/10/2021");

            //Initalize with Default DateTime
            //St1Fee.FeeDate = new DateTime();

            //Initalize with Specfic Date;
            St1Fee.FeeDate = new DateTime(2021, 8, 1);

            //Initalie with Ticks
            //St1Fee.FeeDate = new DateTime(637343000000000000);


            Console.WriteLine();
            Console.WriteLine("Student Fee Detail");
            Console.WriteLine($"Roll Number = {St1Fee.RollNumber}");
            Console.WriteLine($"Fee Amount = {St1Fee.FeeAmount}");
            Console.WriteLine($"Fee Date = {St1Fee.FeeDate}");

            Console.ReadLine();
            //End
        }

        static void C2_ClassConstructor()
        {

            //What is a Constructor?
            //1. Constuctor is just like a Method with the same Class Name and it may have Parameters/Arguemnts but cannot have return value.
            //2. By Default, C# will create a default constuctor automatically with parameter less, if no user defined constuctor is created in that class.
            //3. Constuctor can be used to initalize any field value or execute a code (Perform a Task) whenever the class instance will be created.


            C2_Constructor St1 = new C2_Constructor();  // C2_Constructor() = Default Constructor

            Console.ReadLine();
            C2_Constructor St2 = new C2_Constructor(101);
          
            Console.ReadLine();

            C2_Constructor St3 = new C2_Constructor(1001, "Nabeel", "Sohail", 300F, 68.5F);

            

            Console.WriteLine($"St1 Exam Date = {St1.ExamDate}, St1 Roll Number = {St1.RollNumber}");
            Console.WriteLine($"St2 Exam Date = {St2.ExamDate}, St2 Roll Number = {St2.RollNumber}");
            Console.WriteLine("Std3 Detail");
            Console.WriteLine($"{St3.RollNumber} , {St3.StudentName} , {St3.FatherName} , {St3.TotalMarks} , {St3.Percentage}");



            Console.ReadLine();
           


            //What is Destructor?
            //1. Destructor is just like a method with the same Class Name and cannot have parameters and return value.
            //2. Destructor can be used to clear the resouces. Destructor will be called whenever the instance of a Class is going to be destroyed in memory.
            //3. In C# / .Net, we dont need to create the Destructor for free / clear the resources because .net will do it automatically using its Garbage Collector.
            //4. Destructor starts with ~ Sign.
            //5. ~C2_Constructor() { ....... }





        }

        static void C3_ClassType()
        {
            //In C# we do have Value Type and Reference Type
            //int float struct double decimal are value type
            //string class Array reference type
            //Class is also a Reference Type. Means if we assign a Class Reference variable to any Class Object it will assign the Memory address not the class members values.

            C3_RefrenceType St1 = new C3_RefrenceType();
            St1.RollNumber = 101;
            St1.StudentName = "Nabeel";
            St1.FatherName = "Sohail";
            St1.TotalMarks = 450;
            St1.Percentage = 67.6F;

            C3_RefrenceType St2 = new C3_RefrenceType();
            St2.RollNumber = St1.RollNumber;    //Assign Value

            C3_RefrenceType St3 = St1;  // Assign Class Reference Variable - This is Reference Type means it will assing base address of St1 to St3
            Console.WriteLine($"St1: {St1.RollNumber}, {St1.StudentName}, {St1.FatherName}, {St1.TotalMarks}, {St1.Percentage}");
            Console.WriteLine($"St3: {St3.RollNumber}, {St3.StudentName}, {St3.FatherName}, {St3.TotalMarks}, {St3.Percentage}");

            Console.ReadLine();
            St3.RollNumber = 205;
            St1.TotalMarks = 500;
            Console.WriteLine($"St1: {St1.RollNumber}, {St1.StudentName}, {St1.FatherName}, {St1.TotalMarks}, {St1.Percentage}");
            Console.WriteLine($"St3: {St3.RollNumber}, {St3.StudentName}, {St3.FatherName}, {St3.TotalMarks}, {St3.Percentage}");


            Console.ReadLine();

            TestMethod(St1);
            Console.WriteLine($"St1: {St1.RollNumber}, {St1.StudentName}, {St1.FatherName}, {St1.TotalMarks}, {St1.Percentage}");
            Console.WriteLine($"St3: {St3.RollNumber}, {St3.StudentName}, {St3.FatherName}, {St3.TotalMarks}, {St3.Percentage}");

            Console.ReadLine();

            string n1 = "Sohail";
            string n2 = n1;

            Console.WriteLine($"n1 = {n1}, n2 = {n2}");
            Console.ReadLine();

            n2 = "Nabeel";
            Console.WriteLine($"n1 = {n1}, n2 = {n2}");

            n1 = "ABC";
            n1 = "XYZ";
            Console.ReadLine();

        }

        public static void TestMethod(C3_RefrenceType myStudent)
        {
            myStudent.RollNumber = 104;
            myStudent.StudentName = "Sohail";
            myStudent.FatherName = "Habib";
            myStudent.TotalMarks = 468;
            myStudent.Percentage = 77.6F;
        }

        static void C4_cArray()
        {
            C4_ClassArray[] MyClass =new  C4_ClassArray[4];

            MyClass[0] = new C4_ClassArray();
            MyClass[1] = new C4_ClassArray();
            MyClass[2] = new C4_ClassArray();
            MyClass[3] = new C4_ClassArray();

            for(int i =0;i<4;i++)
            {
                Console.Write($"Enter Roll Number {i + 1}: ");
                MyClass[i].RollNumber = Convert.ToInt16(Console.ReadLine());
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Roll Number {i + 1}: {MyClass[i].RollNumber}");
            }

            Console.ReadLine();

            //MyClass[0].RollNumber = 101;


            //int[] numArray = { 1, 4, 6, 8, 10 };

        }

        static void C5_ClassStaticMembers()
        {

            //By default Class Member Type is Instance
            // Another type is called Static. It is used when the member value is constant and cannot be change.

            C5_StaticMembers Circle1 = new C5_StaticMembers(45.6F);
            Console.WriteLine($"Total Objects = {C5_StaticMembers.GetTotalObjects()}");
  
            C5_StaticMembers Circle2 = new C5_StaticMembers(85F);
            Console.WriteLine($"Total Objects = {C5_StaticMembers.GetTotalObjects()}");


            Console.WriteLine($"Area of Circle 01 = {Circle1.CalculateArea()}");
            Console.WriteLine($"Area of Circle 02 = {Circle2.CalculateArea()}");

            
            Console.ReadLine();
        }

        static void C6_ClassInheritance()
        {
            //Pillars of OOP.
            //1. Inheritance
            //2. Encapsulation
            //3. Abstraction
            //4. Polumorphism

            //1. Inheritance
            //Inheritc Members from once class to another class.

            //Only one Inheritance allowd in CSharp.
            

            C6_Inheritance Parent = new C6_Inheritance();
            C6_ChildInherit Child = new C6_ChildInherit();
            

            Parent.RollNumber = 1001;
            Parent.StudentName = "Nabeel";
            Parent.FatherName = "Sohail";
            Parent.TotalMarks = 300;
            Parent.Percentage = 78.56F;

            
            Child.RollNumber = 1002;
            Child.StudentName = "Sohail";
            Child.FatherName = "Habib";
            Child.TotalMarks = 500;
            Child.Percentage = 80.76F;
            Child.Age = 45;
            Child.Nationality = "Pakistani";

            Console.WriteLine($"Parent : {Parent.RollNumber}, {Parent.StudentName}, {Parent.FatherName}, {Parent.TotalMarks}, {Parent.Percentage}");
            Console.WriteLine($"Child : {Child.RollNumber}, {Child.StudentName}, {Child.FatherName}, {Child.TotalMarks}, {Child.Percentage}, {Child.Age}, {Child.Nationality}");

            Console.ReadLine();

            //For Inheritance minimum 2 classes will be used
            //Base Members will be inherit with Derived Class

            //Whenever Derived class instance will be created first Base class constructor and then Derived Class constructor will be called.


            C6_Inheritance Parent01 = new C6_Inheritance();
            Console.WriteLine("Parent 01 Class instance created.");
            Console.ReadLine();

            C6_ChildInherit Child01 = new C6_ChildInherit();
            Console.WriteLine("Child 01 Class instance created.");
            Console.ReadLine();


            //By Default Derived Class will called Default Base Class Constructor.
            //If we need to invoke specfic Base Class Constructor then we need to specify in the Derived Class what Base Class Constructor we need to invoke.
            //Use base keyword with Derived Class Constructor to specify which Base Class Constructor to be called.

            C6_Inheritance Parent02 = new C6_Inheritance(1010);
            Console.WriteLine("Parent 02 Class instance created.");
            Console.ReadLine();

            C6_ChildInherit Child02 = new C6_ChildInherit();
            Console.WriteLine("Child 02 Class instance created.");
            Console.WriteLine($"Roll Number: {Child02.RollNumber}");
            Console.ReadLine();

            //If you dont want your class to be inherit then declare your class with sealed keyword.

        }

        static void C7_MethodHiding()
        {
            C7_IhMethodHiding Parent = new C7_IhMethodHiding();
            Parent.CalculatePassed();
            Console.ReadLine();

            //By Default CSharp will override the Inheritted Members of Base class if used in Derived Class or hide the Base Class Member and use Derived Class Member

            C7_IhMethodHidingChild Child = new C7_IhMethodHidingChild();
            Child.CalculatePassed();
            Console.ReadLine();

            //How to Call Base Class Method through Child Class Instance.
            //1. Use Type Casting

            C7_IhMethodHidingChild Child02 = new C7_IhMethodHidingChild();
            ((C7_IhMethodHiding)Child02).CalculatePassed();
            
            Console.ReadLine();

            //2. Call Base Class Method directly in Derived Class Method using base keyword.

            //3. Initiate Child Class Object  using Parent Class Object - This concept caleld POLYMORPHISM
        }

        static void C8_Polymorphism()
        {
            //Base Class Reference Variable can point to a Derived Class Object(Instance). This concept is called Polymorphism.

            //Default Inheritance Behaviour without using Polymorphism
            Console.WriteLine("Default Inheritance Behaviour without using Polymorphism");
            C8_PolymorphismBase Parent = new C8_PolymorphismBase();
            C8_PolymorphismChild01 FullTime = new C8_PolymorphismChild01();
            C8_PolymorphismChild02 PartTime = new C8_PolymorphismChild02();
            C8_PolymorphismChild03 TempEmp = new C8_PolymorphismChild03();

            Parent.FirstName = "Nabeel";
            Parent.LastName = "Sohail";
            Parent.Gender = "Male";

            FullTime.FirstName = "Sohail";
            FullTime.LastName = "Habib";
            FullTime.Gender = "Male";
            FullTime.Salary = 50000F;

            PartTime.FirstName = "Ismat";
            PartTime.LastName = "Sohail";
            PartTime.Gender = "Female";
            PartTime.SalaryPerHour = 1500F;

            TempEmp.FirstName = "Raheel";
            TempEmp.LastName = "Habib";
            TempEmp.Gender = "Male";
            TempEmp.SalaryPerProject = 10000F;

            Console.WriteLine($"Parent - {Parent.FullName()}");
            Console.WriteLine($"Full Time - {FullTime.FullName()}");
            Console.WriteLine($"Part Time - {PartTime.FullName()}");
            Console.WriteLine($"Temp Emp - {TempEmp.FullName()}");

            Console.ReadLine();

            //Inheritance Behaviour using Polymorphism
            Console.WriteLine("Inheritance Behaviour using Polymorphism");
            C8_PolymorphismBase Parent01 = new C8_PolymorphismBase();
            C8_PolymorphismBase FullTime01 = new C8_PolymorphismChild01();
            C8_PolymorphismBase PartTime01 = new C8_PolymorphismChild02();
            C8_PolymorphismBase TempEmp01 = new C8_PolymorphismChild03();

            

            //Derived Class Reference Variable cannot cretae Base Class Instance
            //C8_PolymorphismChild01 Parent02 = new C8_PolymorphismBase();

            Parent01.FirstName = "Nabeel";
            Parent01.LastName = "Sohail";
            Parent01.Gender = "Male";

            FullTime01.FirstName = "Sohail";
            FullTime01.LastName = "Habib";
            FullTime01.Gender = "Male";
            //FullTime01.Salary = 50000F;

            PartTime01.FirstName = "Ismat";
            PartTime01.LastName = "Sohail";
            PartTime01.Gender = "Female";
            //PartTime01.SalaryPerHour = 1500F;

            TempEmp01.FirstName = "Raheel";
            TempEmp01.LastName = "Habib";
            TempEmp01.Gender = "Male";
            //TempEmp01.SalaryPerProject = 10000F;

            Console.WriteLine($"Parent01 - {Parent01.FullName()}");
            Console.WriteLine($"Full Time01 - {FullTime01.FullName()}");
            Console.WriteLine($"Part Time01 - {PartTime01.FullName()}");
            Console.WriteLine($"Temp Emp01 - {TempEmp01.FullName()}");

            Console.ReadLine();
        }

        static void C9_MethodOverRiding()
        {
            //By Default in Polymorphism Derived class Methods will be hidden and Base Class Methods will be invoked.

            //Now we want to hide Base Class Methods and invoke Derived Class Methods.
            //This concept is called Method Overriding.
            //To Achieve this we need to tell Base Class method that it can be overrride using virtual keyword
            //And override keyword will be used in Derived Class Methods.


            //Inheritance Behaviour using Polymorphism
            Console.WriteLine("Inheritance Behaviour using Polymorphism");
            C9_MethodOverRidingBase Parent01 = new C9_MethodOverRidingBase();
            C9_MethodOverRidingBase FullTime01 = new C9_MethodOverRidingChid01();
            C9_MethodOverRidingBase PartTime01 = new C9_MethodOverRidingChid02();
            C9_MethodOverRidingBase TempEmp01 = new C9_MethodOverRidingChid03();



            //Derived Class Reference Variable cannot cretae Base Class Instance
            //C8_PolymorphismChild01 Parent02 = new C8_PolymorphismBase();

            Parent01.FirstName = "Nabeel";
            Parent01.LastName = "Sohail";
            Parent01.Gender = "Male";

            FullTime01.FirstName = "Sohail";
            FullTime01.LastName = "Habib";
            FullTime01.Gender = "Male";
            //FullTime01.Salary = 50000F;

            PartTime01.FirstName = "Ismat";
            PartTime01.LastName = "Sohail";
            PartTime01.Gender = "Female";
            //PartTime01.SalaryPerHour = 1500F;

            TempEmp01.FirstName = "Raheel";
            TempEmp01.LastName = "Habib";
            TempEmp01.Gender = "Male";
            ((C9_MethodOverRidingChid03)TempEmp01).SalaryPerProject = 10000F;

            Console.WriteLine($"Parent01 - {Parent01.FullName()}");
            Console.WriteLine($"Full Time01 - {FullTime01.FullName()}");
            Console.WriteLine($"Part Time01 - {PartTime01.FullName()}");
            Console.WriteLine($"Temp Emp01 - {((C9_MethodOverRidingBase)TempEmp01).FullName()}");

            Console.ReadLine();
        }

        static void C10_TopicEncapsulation()
        {
            //without encapsulation
            C1_Student Std01 = new C1_Student();
            Std01.RollNumber = 1001;
            Std01.StudentName = "Nabeel";
            Std01.FatherName = "Sohail";
            Std01.TotalMarks = 800;
            Std01.Percentage = 65.5F;

            //Encapsulation - For Fields
            //Hide Fields Data - Secure Fields Data

            //Marking the class fields public and exposing to the external words is bad, as you will not
            //have control over what gets assigned and returned.

            //Business Validation???
            //C1_Student Class User can assign any numeric value in Roll Number like 0, -100 etc.
            //User can assign any String value in Student Name like "100", "ABC123", "A" etc...

            //OOP introduces getter and setter methods to solve this issue. This concept is called Encapsulation.
            C10_Encapsulation Std02 = new C10_Encapsulation();
            Std02.SetRollNumber(101);
            Std02.SetStudentName("abff");

            Console.WriteLine(Std02.GetRollNumber());
            Console.WriteLine(Std02.GetStudentName());
            Console.ReadKey();
                      
            

        }

        static void C11_EncapProperties()
        {

            //Properties 
            //In OOP to enhance the Encapsulation and shorter the code, they intorduces Properties.
            //Languages does not support Properties, still using Getter and Setter Methods to Encapsulate.

            //Properties Type
            //1. Read/Write
            //2. Read Only
            //3. Write Only

            C11_Properties Std01 = new C11_Properties();
            Std01.RollNumber = 101;
            Std01.StudentName = "Nabeel";
            Std01.FatherName = "Sohail";
            Std01.TotalMarks = 170;
            Std01.MobileNumber = "0345-3425677";
            Std01.EmailAddress = "sample@gmail.com";

            Console.WriteLine(Std01.RollNumber);
            Console.WriteLine(Std01.StudentName);
            Console.WriteLine(Std01.FatherName);
            Console.WriteLine(Std01.ExamDate);
            Console.WriteLine(Std01.TotalMarks);
            Console.WriteLine(Std01.Percentage);
            Console.WriteLine(Std01.IsPassed);
            Console.WriteLine(Std01.MobileNumber);
            Console.WriteLine(Std01.EmailAddress);

            Console.ReadLine();

            //in C# 3.0, they introduced Auto Implemented Properties.
            //user does not need to create Private Fields, Set and return values.  C# will do it automatically.

            //Creating Class Using Object Initializer Syntax - Introduced in C# 3.0
            C11_Properties std02 = new C11_Properties
                                        {
                                            RollNumber = 111,
                                            StudentName = "Sohail",
                                            FatherName = "hABIB",
                                            EmailAddress = "SOHAIL@GMAIL"
                                        };


        }

        static void C12_StaticClassTopic()
        {
            //By Default class type is instance.
            //In C#, static means something which cannot be initiated. You cannot create an object of a static class and cannot access static members using object.
            //If Class is static then all the members must be static

            int SumResult = C12_StaticClass.Sum(100, 200);
            C12_StaticClass.Store(SumResult);
            C12_StaticClass.Type = "Scientific";

            Console.WriteLine($"Result = {C12_StaticClass.GetResult()}");
            Console.WriteLine($"Result = {C12_StaticClass.Type}");

            Console.ReadLine();

            //Rules
            //1. Static class cannot be initiated.
            //2. All the members must be static.
            //3. A Static class cannot contain instance members and constructors.
            //4. Static classes are sealed and therefore cannot be inherited.
            //5. Static class members can be accessed using ClassName.MemberName
            //6. Static class remains in memory for the lifetime of the application domain in which your program resides.

      
        }

        static void C13_PartialClassTopic()
        {
            //Partial - Part of a Class
            //One Complete Class can be splitted into more than one Partial Classes.
            //By Default Public Class Name cannot be duplicate.

            Student St1 = new Student();
            St1.RollNumber = 101;


            //Rules
            //1. All the Partial class definations must be in the same assembly and namespace.
            //2. All the parts must have the same accessiblity like public or private.
          
        }

        static void C14_NestedClassTopic()
        {
            StudentProfile.Add AddSt1 = new StudentProfile.Add();
            StudentProfile.Update UpdateSt1 = new StudentProfile.Update();
            
        }

        private static void C17_AbstractionClass()
        {
            //Use abstract keyword to create Abstract Classes
            //Abstract means incomplete class
            //Abstract method cannot have implementation
            //cannot create the instact of Abstract Classes
            //Non Abstract class inherits from Abstract class and this Non Abstract class will provide the implementation 
            //Abstract class can also inherit from another Abstract Class
            //Abstract class can only be used as a base class
            //Abstract class cannot be sealed.
            //Abstract class can have abstract members but its not mandatory. Means Abstract calss can have implemented methods too.
            //Abstract Class Reference variable can point to Non Abstract Class.
        }

        private static void C16_ExplicitInt()
        {

            //Explict Interface using Type Cast
            C16_Employee Emp01 = new C16_Employee();
            Console.WriteLine(((IC16_ExplicitInterface01)Emp01).PrintDetail());
            Console.WriteLine(((IC16_ExplicitInterface02)Emp01).PrintDetail());
            Console.ReadLine();

            //using Polymorphism
            IC16_ExplicitInterface01 Emp02 = new C16_Employee();
            Console.WriteLine(Emp02.PrintDetail());
            Console.ReadLine();

        }

        private static void C15_InterfaceTopic()
        {
            //Interface is just like a class but does not contain any member (Method) implementation
            //Interface also contains Properties, methods etc. but only declaration/Defination and no implementation.
            //interface keyword will be used to create Interface.
            //Interface will only contain declaration, and the implementation will be in a class which will be inherit from thsi interface.
            //Interface naming starts with I
            //Interface members are by default Public and they dont allow explicit access modifiers.

            C15_Employee Emp01 = new C15_Employee()
            {
                EmployeeID = 1001,
                FirstName = "Nabeel",
                LastName = "Sohail",
                Salary = 50000
            };

            Console.WriteLine($"Employee Detail = {Emp01.Print()}");
            Console.WriteLine($"Employee Overtime = {Emp01.CalculateOvertime(Emp01.Salary)}");

            Console.ReadLine();

            //Interface can inherit from another Interface.
            //Class can be inherit from multiple Interfaces.
            //Class can inherit from a Class and Interfaces together.

            //We Cannot create the instance of Interace

            //IC15_Interface IEmp = new IC15_Interface();   //throw exception

            //Polymorphism can be apply. Interface Reference Variable can point to Class Instance.
            IC15_Interface Emp = new C15_Employee();
            ((C15_Employee)Emp).EmployeeID = 1002;

            Console.WriteLine($"{Emp.Print()}");
            Console.WriteLine($"{((C15_Employee)Emp).Print()}");

            Console.ReadLine();

        }
    }

    //class Student
    //{
    //    Create Fields in class Student
    //    public int RollNumber;
    //    public string StudentName;
    //    public string FatherName;
    //    public float TotalMarks;
    //    public float Percentage;
    //    public DateTime ExamDate = DateTime.Now;  //Return Current Date Time - Now = Property
    //    bool isPassed;
    //}


}