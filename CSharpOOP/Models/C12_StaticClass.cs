using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Models
{
    public static class C12_StaticClass
    {
        //Calculator
        private static int _resultStorage = 0;
        public static string Type = "Arithmetic";

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Store(int result)
        {
            _resultStorage = result;
        }

        public static int GetResult()
        {
            return _resultStorage;
        }
    }
}
