using System;
using System.Reflection;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Example1 e = new Example1();
            Type m1 = typeof(Example1);
            foreach (object a in m1.GetCustomAttributes(true))
            {
                Console.WriteLine(a.ToString());
            }
            Example1.Executemain();

            MethodInfo[] n= m1.GetMethods();
            foreach (MemberInfo a in n) {
                Console.WriteLine(a.Name+"  "+a.GetType());
            }

            Type m3 = typeof(Ex2);
            MethodInfo[] d1 = m3.GetMethods();
            foreach (MethodInfo nn in d1) { Console.WriteLine(nn.Name); }
        }
    }
}
