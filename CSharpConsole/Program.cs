//namespace Area
using System;

/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/

//Full Qualifier Name

namespace CSharpConsole //Project Name
{
    //console program can also run without namespace
    class Program //Program File Program.cs
    {
        /// <summary>
        /// This is my Main Method to execute my C# Program
        /// </summary>
        /// <param name="args">String Array Value</param>
        static void Main(string[] args) //Method - Main Method is the Entry Point into your application.
        {

            //Variables
            //Syntax
            //Access Modifier <DataType> ReferenceVariable
            //By Default Access Modifier is Private
            //Variable can be declared anywhere in the program
            //Scope of variable is a block level for Private Access Modifier
            //boolean, integral, floating, string

            /*
            int Num1;   //Declaring
            Num1 = 20;  //Initializing
            int Num2 = 78;
            float Perc = 78.67F;
            double Pi = 3.1426D;
            char ch = 'a';
            string MyName = "Nabeel Sohail";
            string FolderPath = "E:\\Programming-Web-DB\\C#";

            //Verbatim Literals (@) - Make Escape Sq translates as normal printable char to enhance readabilty
            string FolderPath2 = @"E:\\Programming-Web-DB\C#";

            //

            //Constant Variables
            //const int MyAge = 21;

            //Declare as much as in one statement
            //int a = 2, b = 9, c = 19, d = 8;
            //int force = 10; double g = 9.11D;

            //Display
            Console.Write("Hello World! This is my first C Sharp Program\t");
            Console.Write("Lets Start C#\n");

            Console.WriteLine(Num1);
            Console.WriteLine(Num2);
            Console.WriteLine(Perc);
            Console.WriteLine(Pi);
            Console.WriteLine(ch);
            Console.WriteLine(MyName);

            Console.WriteLine("Min Value of Int = " + int.MinValue);
            Console.WriteLine("Max Value of Int = " + int.MaxValue);

            Console.WriteLine(FolderPath);
            Console.WriteLine(FolderPath2);

            Console.WriteLine();
            Console.WriteLine();

            //ReadLine
            string MyFullName;
            string MyAge;

            Console.Write("Enter Name : ");
            MyFullName = Console.ReadLine();
            Console.Write("Enter Age : ");
            MyAge = Console.ReadLine();

            Console.WriteLine(MyFullName);
            Console.WriteLine(MyAge);

            //String Concat
            Console.WriteLine("Your Name is : " + MyFullName + " and your age is : " + MyAge);
            //Placeholder Syntax
            Console.WriteLine("Your Name is : {0} and your age is : {1}",MyFullName,MyAge);
            //Str Interpolation ($) - introduced in c# v6
            Console.WriteLine($"Your Name is : {MyFullName} and your age is : {MyAge}");
            string printmsg = $"Your Name is : {MyFullName} and your age is : {MyAge}";
            Console.WriteLine(printmsg);



            // Operators
            //Assignment =, Arithmatic Opertator + - * / %
            //Increament Decrement ++, --, n+=5 (n = n + 5), n-=5, n*=5, n/=5)
            //Comparison Operators - ==, !=, <=, >=, > , < (Note: >= and => (Arrow Function/Lambda Expression) diferent)
            // Conditional Operators &&, ||, !
            //Ternary Operator - ? : (Conditional Statement - Single Line - Short hand of Single If)
            //Null Coalescing Operator (??)
            //Bitwise Oerators - &, |, ^ (XOR), `(Binary 1s Complement), >> (Binary Left Shift), << (Binary Right Shift)

            //Types in C# (int, float, bool, structs, enum, String, Class, Interface, Delegates, Arrays etc)
            //Two Types of Types (Object)
            //1. Value Type (int, float, bool, structs, enums etc) - Non Nullable
            //2. Reference Type (Pointer) String, Interface, Class, Delegates, Arrays etc) - Nullable

            int MyValue1;
            MyValue1 = 200; //valid Value
            //MyValue1 = null; //Value type cannot be null (by default behaviour)


            string EmpName="Sohail Abdul Habib";
            float Salary = 50000F;
            int age = 47;

            //How to make value type as nullable - Explicit, cannot be nullable implicit
            //Use ? to mark type explicit nullable
            int? deduction;  //can be null - 0
            deduction = null;

            int deduction2;
            deduction2 = 300;

            int totaldeduction;
            deduction = 200;


            //totaldeduction = deduction+deduction2; //Produce Error because deduction can be NULL so calculation cannot perform


            string Address; //can be null


            string MyName1 = null;

            //Null Coalescing Operator (??)
            //Nullable type cannot imlicit convert to Non Nullable Type

            int? abc = null;
            int xyz;



            abc = 10;
            //xyz = abc; // Produce Error because Nullable cannot implict convert to Non Nullable

            //Solution: Explicit convert Nullable into Non Nullable using value Property
            xyz = abc.Value;

            //Solution 2: Explicit convert Nullable into Non Nullable using Type Cast 
            xyz = (int)abc;



            Console.WriteLine($"Value of abc = {abc}");
            Console.WriteLine($"Value of xyz = {xyz}");

            //Solution 2: Explicit convert Nullable into Non Nullable using Null Coalescing Operator ??
            int? TicketOnSale = null;
            //TicketOnSale = 20;



            int AvailableTickets = TicketOnSale ?? 0;   // Assign 0 if TicketOnSale is Null;

            Console.WriteLine($"Available Tickets: {AvailableTickets}");


            //Data Type Conversion - Type Casting
            //1. Implicit - Done by Compiller Automatically (Lower to Higher) - No Loss of Data (char->int->long->float->double)
            //2. Explicit - Done by User Manuwally (double->float->long->int->char)

            //Implicit Example

            int n1 = 20;
            double n2;
            n2 = n1;

            //Explicit
            n2 = 6754;


            //Step 1: using data type in Source
            n1 = (int)n2;

            Console.WriteLine($"n2={n2}");
            Console.WriteLine($"n1={n1}");

            string MyStrValue = "A4500";
            //Step 2: Using Dot Net Convert Library
           // n1 = Convert.ToInt16(MyStrValue);
            Console.WriteLine($"n1={n1}");

            //Solution 3: Parse - TryParse
            //Step 3: Using Parse Method
           // n1 = int.Parse(MyStrValue);
            Console.WriteLine($"n1={n1}");

            //Try Parse - Make sure if your data can be converted. - Return True/False
            bool result = int.TryParse(MyStrValue, out n1);
            Console.WriteLine($"n1={n1}");
            Console.WriteLine($"Result={result}");


            //Arrays - Store list of data in the same data type or Store more than one value in the same data type.

            //Declare Array
            int[] listNumber;

            //Initialize - Index 0-2
            listNumber = new int[3];

            //Store / Access (Set/Get)
            listNumber[0] = 20;
            listNumber[1] = 30;
            listNumber[2] = 40;

            //if we try to get or set additional index element then Run time error will throw
            //listNumber[3] = 50;
            //listNumber[4] = 60;

            Console.WriteLine($"My ListNumber Array: {listNumber[0]}, {listNumber[1]}, {listNumber[2]}, Array Length={listNumber.Length}");

            //Declare and Initalize
            string[] listNames = new string[5];
            listNames[0] = "Nabeel Sohail";
            listNames[1] = "Ismat Sohail";
            listNames[2] = "Umair Sohail";
            listNames[3] = "Hassaan Sohail";
            listNames[4] = "Sakeena Sohail";

            Console.WriteLine($"List Names : {listNames[0]}, {listNames[1]}, {listNames[2]}, {listNames[3]}, {listNames[4]}, Array Length={listNames.Length}");

            //Declare, Initialize, Store
            int[] MyNumbers = new int[4] { 1, 3, 5, 7 };
            int[] MyOddNumbers = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] EvenNubers = { 1, 3, 5, 7, 9 };


            MyOddNumbers = new int[10];


            //Copy Array Object - In Memory a copy of new Array Values will be created.
            int[] MyNumbersCopy = MyNumbers;


            Console.WriteLine($"MNumber[0] = {MyNumbers[0]}, MyNumbersCopy[0]={MyNumbersCopy[0]}");

            //Object can be Re-Initalize, but after Re-Initalize old values will be lost.
            listNumber = new int[10];
            Console.WriteLine($"My ListNumber Array: {listNumber[0]}, {listNumber[1]}, {listNumber[2]}, Array Length={listNumber.Length}");



            //Comments in C#
            // Single Line Comment
            // Block Comment
            // XML Documentation /// It will show Tool Tip in VS Intellisence

            
            // Conditional Statement
            // if

            int n1 = 10;
            int n2 = 20;

            if(n1>n2)
            {

            }
            else
            {

            }

            //Difference Between || vs | and && vs &
            //|| If any condition will be true, others condition will not be checked.
            //| all conditions will be checked.
            //&& if any condition will be false, others condition will not be checked.
            //& all conditions will be checked.
            if(n1==20 || n1==10 || n1==10 )
            {
                Console.WriteLine("n1 is ok");
            }
            else
            {
                Console.WriteLine("n1 is not ok");
            }

            //switch - can be used for Nested IF

            // break can be used to terminate the code 


            //Loops
            // While
            int c = 10; 
            while(c<10)
            {
                Console.WriteLine(c);
                c++;
            }

            int cc = 10;
            do
            {
                Console.WriteLine(cc);
                cc++;
            }
            while (cc < 10);

            for(int i=0;i<=10;i++)
            {
                Console.WriteLine("Sohail");
            }

            //for-each - Used for Objects Collection

            string[] MyCars = { "Toyota", "Witz", "Parado", "Tahoe", "Audi" };

            for(int l=0;l<MyCars.Length;l++)
            {
                Console.WriteLine(MyCars[l]);
            }

            int abc = 1;
            foreach(string Car in MyCars )
            {
                Console.WriteLine(Car);
                abc++;
                if(abc==3)
                {
                    break;
                }

            }
            */

            //Methods - Old Terminolgy: Functions 

            //Method Syntax
            // [Attributes] [AccessModifier] ReturnType Method_Name(Parameter(s) List)


            //Normal Method Example

            //Instance Method: (By Default)
            //If any method available in Class Block, then the class must be initalize (Creating Instance Object of the class) beore accessing the Methods
            //Program = Class Name, myProgram = Reference Variable of Class Program Type, new Program() = New Instance of Program Type
            Program myProgram = new Program(); //Initalize Program Class / Create Instance
            int myn1 = 100, myn2 = 200;
            int result = myProgram.AddNumbers(myn1, myn2);
            myProgram.Wait($"The sum = {result}");

            //Static Method
            //Static Method does not require class initialization. Method can be accessed by using Full Qualifier Name.
            myProgram.Wait($"Product is {Program.ProductNumber(5, 10)}");


            //Pass Refernce (Memory Address) of myn1 reference variable
            Console.WriteLine($"Value of myn1 before calling Reference Method {myn1}");
            ChangeValue(ref myn1);
            Console.WriteLine($"Value of myn1 after calling Reference Method {myn1}");

            //Out Parameter Example
            int mPr = 0;
            int sum = myProgram.Calcualte(10, 5, out mPr);
            Console.WriteLine($"Sum = {sum}, Product = {mPr}");

            int[] myN = { 1, 6, 9, 3, 6 };

            Console.WriteLine($"Sum of Array = {myProgram.SumNumbers(myN)}");

            //Parameter Array Example
           int ArraySum = myProgram.SumNumbers2(1,4,6,7,8);
            Console.WriteLine($"Sum of Array using Param = {ArraySum}");
            ArraySum = myProgram.SumNumbers2(myN);
            Console.WriteLine($"Sum of Array using Param = {ArraySum}");


            Console.WriteLine( myProgram.SumNumbers3("The sum of my Array Values",1, 4, 6, 7, 8));
            Console.WriteLine(myProgram.SumNumbers3("The sum of my Array Values"));


            //Named Argument
            myProgram.MyMethod(str: "Sohail", department: "HR", countrycode: 92, num: 200);

            myProgram.MyMethod2(department: "HR", countrycode: 92, num: 200);
            myProgram.MyMethod2(200,92,"IT");

            myProgram.MyMethod3(num:300,department:"Finance");
            //Console.WriteLine("Tet");
            Console.Read();
        }

        //Method Parameter Types
        //1. Value Parameter    -  A copy of value will be created in the memory.
        //2. Reference Parameter
        //3. Out Parameter (Output)
        //4. Parameter Arrays
        //5. Names Argument


        //Add Two Numbers - 2 Parameters, Integer Return;
        //Instance Method - By Default
        //Parameter Type: Value Parameter - 

        /// <summary>
        /// Add Two Integer
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        int AddNumbers(int n1, int n2)
        {

            return n1 + n2;
        }

        /// <summary>
        /// Add Two Float
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        //Method Overloading - More than one Method Defination for the same method name. Parameter must be different (numbers, type)
        float AddNumbers(float n1, float n2)
        {

            return n1 + n2;
        }

        double AddNumbers(double n1, double n2)
        {

            return n1 + n2;
        }

        int AddNumbers(int n1, int n2,int n3)
        {

            return n1 + n2+n3;
        }

        //Static Method
        static int ProductNumber(int n1, int n2)
        {
            return n1 * n2;
        }

         void Wait(string WaitMessage)
        {
            Console.WriteLine(WaitMessage);
            Console.ReadKey();
        }

        //Static - Referene Type Parameter (Pointer - Store Address of the Passed Value/Object
        static void ChangeValue(ref int n1)
        {
            n1 = n1 * 2;
        }

        //Instance - out type Parameter 
        //Number of Return Value Parameter: Maximum 1 (Method cannot return more than 1 value);
        //To Solve this we can use out type Parameter

        int Calcualte(int n1, int n2,out int pn)
        {
            pn = n1 * n2;
            return n1 + n2;
        }

        int SumNumbers(int[] NumList)
        {
            int result=0;
            
            foreach(int n in NumList)
            {
                result = result + n;
            }
            return result;
        }

        //Param Parameter must be the last parameter
        int SumNumbers2(params int[] NumList)
        {
            int result = 0;

            foreach (int n in NumList)
            {
                result = result + n;
            }
            return result;
        }

        string SumNumbers3(string MyStr, params int[] NumList)
        {
            int result = 0;

            foreach (int n in NumList)
            {
                result = result + n;
            }
            return $"{MyStr} = {result}";
        }

        //Named Arguement
        void MyMethod(int num, string str, int countrycode, string department)
        {
            Console.WriteLine($"{num}, {str}, {countrycode}, {department}");
        }

        //Default Parameter Value
        void MyMethod2(int num, int countrycode, string department, string str = "Sohail")
        {
            Console.WriteLine($"{num}, {str}, {countrycode}, {department}");
        }

        void MyMethod3(int num, string department, string str = "Sohail", int countrycode = 92)
        {
            Console.WriteLine($"{num}, {str}, {countrycode}, {department}");
        }

    }
}


