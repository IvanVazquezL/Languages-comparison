//Rextester.Program.Main is the entry point for your code. Don't change it.
//Microsoft (R) Visual C# Compiler version 2.9.0.63208 (958f2354)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        static int Sum(int a,int b)
        {
          return a+b;
        }

        public static void Main(string[] args)
        {
          Console.WriteLine(Sum(1,2));
        }
    }
}
