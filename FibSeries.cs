using System;
using System.Collections.Generic;
using System.Text;

namespace AshwiniApp
{
    class FibSeries
    {

        public static void fibPrint(int n) {
            int n1 = 1;
            int n2 = 1;
            Console.WriteLine("Fibonacci series is printed here ");
            Console.Write(n1+" "+n2);
            for (int i = 0; i < n; i++) {
                int n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                Console.Write("  "+n3);
            }
        
        }
    }
}
