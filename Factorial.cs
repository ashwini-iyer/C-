using System;
using System.Collections.Generic;
using System.Text;

namespace AshwiniApp
{
    class Factorial
    {


        public static void printFactorial(int n) {
            int fact = 1;
            for (int i = 1; i <= n; i++) {
                fact = fact * i;
             }
            Console.WriteLine("The factorial of the number {0} is {1}",n,fact);
        }
    }
}
