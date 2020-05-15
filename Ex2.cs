using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionDemo
{
    class Ex2
    {



    }
    
    class AddAlt : System.Attribute{
        public int i;
        public string name;
        public AddAlt()
        {
            Console.WriteLine("Constructor of Add alt here ");

        }

            public AddAlt(string msg, )
            {
                Console.WriteLine("Constructor of Add alt here ");

            }
    public string namefunc { get; set; }
    }
}
