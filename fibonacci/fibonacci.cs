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
        static Queue<int> Fibonacci(int n)
        {
            int num1 = 0;
            int num2 = 1;
            int num3;
            int i = 3;
            Queue<int> myQueue = new Queue<int>();

            if(n==1)
            {
                myQueue.Enqueue(num1);
                return myQueue;
            }
            else if(n==2){
                myQueue.Enqueue(num1);
                myQueue.Enqueue(num2);
                return myQueue;
            }
            else{
                myQueue.Enqueue(num1);
                myQueue.Enqueue(num2);

                while(i <= n)
                {
                    num3 = num1+num2;
                    myQueue.Enqueue(num3);
                    num1=num2;
                    num2=num3;
                    i++;
                }
                return myQueue;
            }
        }

        public static void Main(string[] args)
        {
            Queue<int> receiver;
            receiver = Fibonacci(13);

            foreach (int value in receiver)
            {
                Console.WriteLine(value);
            }
        }
    }
}
